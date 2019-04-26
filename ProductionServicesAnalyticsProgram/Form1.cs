using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.ObjectModel;
using System.IO;
using System.Diagnostics;
using System.Globalization;


namespace ProductionServicesAnalyticsProgram
{
    public partial class Form1 : Form
    {
        //replace with time selection
        int period = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
        //end replacement section

        //key is index and value is full name separated by a space
        Dictionary<String, int> indexByName;


        int[] minutesPerWorkerByDay, minutesPerWorkerByMonth, minutesPerWorkerByYear;

        int totalDays;



        public Form1()
        {
            InitializeComponent();

            
        }
        private void paperaEdit(ref string[] dataArray)
        {
            if (dataArray[3].Contains("I") || dataArray[3].Contains("V") || dataArray[3].Contains("X"))
            {
                dataArray[2] += " " + dataArray[3];
                for(int i = 3; i < dataArray.Length - 1; i++)
                {
                    dataArray[i] = dataArray[i + 1];
                }
            }
        }
        
        private bool checkZStaffOrNeeded(string data)
        {
            if (data.Contains("Z-Staff") || data.Contains("Z-NEEDED") || data.Contains("Person"))
                return true;
            else
                return false;
        }

       
        private void submitButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Starting data grab...\nPlease wait for a completion dialog.\nPress OK to begin.");

            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                System.IO.File.WriteAllLines(@"userData.txt", new string[] { usernameBox.Text, passwordBox.Text });
            }

            String user = usernameBox.Text;
            String pass = passwordBox.Text;

           

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");

            IWebDriver driver = new ChromeDriver(driverService, options);
            driver.Url = "http://172.21.20.41/cepdotnet/CEPloginToCEP.aspx";



            IWebElement username = driver.FindElement(By.Id("txtUserName"));
            IWebElement password = driver.FindElement(By.Id("txtPassword"));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            IWebElement lgnBtn = driver.FindElement(By.Id("sbtLogin"));
            lgnBtn.Click();


            IReadOnlyCollection<IWebElement> elements;
            indexByName = new Dictionary<String, int>();


            //grab all names and store them in the dictionary
            int indexForDictionary = 1;
            indexByName.Add("All", 0);

            driver.Url = "http://172.21.20.41/cepdotnet/CEPemployeeSearch.aspx";
            elements = driver.FindElements(By.ClassName("CEPSub"));
            String tempFirstName = "", tempLastName = "", tempElementText;

            foreach (IWebElement element in elements)
            {
                if (element.Text.Contains("NoEmail@.xxx"))
                    break;
                tempLastName = element.Text.Substring(0, element.Text.IndexOf(",") - 1);
                tempElementText = element.Text.Substring(tempLastName.Length + 3);
                tempFirstName = tempElementText.Substring(0, tempElementText.IndexOf(" "));
                indexByName.Add(tempFirstName + " " + tempLastName, indexForDictionary);
                indexForDictionary++;
            }


            totalDays = (endDate.Value.Date - startDate.Value.Date).Days + 1;
            //make the array of minutes per worker

            int dayIndexChange = 0, monthIndexChange = 0, yearIndexChange = 0;

            if (analysisTypeCheckBoxList.GetItemChecked(0))
            {
                minutesPerWorkerByDay = new int[indexForDictionary * ((endDate.Value.Date - startDate.Value.Date).Days + 1)];
            }
            if (analysisTypeCheckBoxList.GetItemChecked(1))
            {
                minutesPerWorkerByMonth = new int[indexForDictionary * ((endDate.Value.Year - startDate.Value.Year) * 12 + (endDate.Value.Month - startDate.Value.Month) + 1)];
            }
            if (analysisTypeCheckBoxList.GetItemChecked(2))
            {
                minutesPerWorkerByYear = new int[indexForDictionary * ((endDate.Value.Year - startDate.Value.Year) + 1)];
            }
            //start analysis by day

            String[] tempElementArray, tempWorkerDataArray;
            String tempStartTime, tempEndTime;

            int tempTime;


            int cMonth = startDate.Value.Month, cDay = startDate.Value.Day, cYear = startDate.Value.Year;
            for (int dateCounter = (endDate.Value.Date - startDate.Value.Date).Days+1; dateCounter > 0; dateCounter--)
            {
                driver.Url = "http://172.21.20.41/cepdotnet/CEPHome.aspx?day=" + cDay + "&month=" + cMonth + "&year=" + cYear;

                //grabs all events for current selected day
                elements = driver.FindElements(By.ClassName("CEPDaySub"));
                foreach (IWebElement element in elements)
                {
                    //data on individual workers starting at index 3 (inclusive)
                    tempElementArray = element.Text.Split('\n');
                    for (int i = 3; i < tempElementArray.Length; i++)
                    {
                        //0: first name
                        //1: last name
                        //2: start time
                        //3: start time AM/PM
                        //4: end time
                        //5: end time AM/PM

                        

                        tempWorkerDataArray = tempElementArray[i].Split(' ');



                        if (!checkZStaffOrNeeded(tempWorkerDataArray[2]))
                        {

                            //The Papera edit
                            paperaEdit(ref tempWorkerDataArray);


                            tempStartTime = tempWorkerDataArray[3];

                            if (tempStartTime.Contains("MIDNIGHT") || tempStartTime.Contains("NOON"))
                            {
                                tempEndTime = tempWorkerDataArray[4];
                                if (!(tempEndTime.Contains("MIDNIGHT") || tempEndTime.Contains("NOON")))
                                {
                                    tempEndTime += " " + tempWorkerDataArray[5];
                                }
                            }
                            else
                            {
                                tempStartTime += " " + tempWorkerDataArray[4];
                                tempEndTime = tempWorkerDataArray[5];
                                if (!(tempEndTime.Contains("MIDNIGHT") || tempEndTime.Contains("NOON")))
                                {
                                    tempEndTime += " " + tempWorkerDataArray[6];
                                }
                            }
                            
                            tempTime = findMinutes(tempStartTime, tempEndTime);

                            if (analysisTypeCheckBoxList.GetItemChecked(0))
                            {
                                minutesPerWorkerByDay[indexByName[tempWorkerDataArray[1] + " " + tempWorkerDataArray[2]] + (dayIndexChange * indexForDictionary)] += tempTime;
                                minutesPerWorkerByDay[dayIndexChange * indexByName.Count] += tempTime;
                            }
                            if (analysisTypeCheckBoxList.GetItemChecked(1))
                            {
                                minutesPerWorkerByMonth[indexByName[tempWorkerDataArray[1] + " " + tempWorkerDataArray[2]] * (monthIndexChange * indexForDictionary)] += tempTime;
                                minutesPerWorkerByMonth[monthIndexChange * indexByName.Count] += tempTime;
                            }
                            if (analysisTypeCheckBoxList.GetItemChecked(2))
                            {
                                minutesPerWorkerByYear[indexByName[tempWorkerDataArray[1] + " " + tempWorkerDataArray[2]] * (yearIndexChange * indexForDictionary)] += tempTime;
                                minutesPerWorkerByYear[yearIndexChange * indexByName.Count] += tempTime;
                            }
                        }
                    }

                }

                cDay++;
                dayIndexChange++;
                int daysInMonth = System.DateTime.DaysInMonth(cYear, cMonth);
                if (cDay > daysInMonth)
                {
                    cDay = 1;
                    cMonth++;
                    monthIndexChange++;
                    if (cMonth > 12)
                    {
                        cMonth = 1;
                        cYear++;
                        yearIndexChange++;
                    }

                }

            }
            driver.Quit();


            //sets up list boxes to current instance
            analysisTypeListBox.DataSource = analysisTypeCheckBoxList.CheckedItems;
            nameListBox.DataSource = indexByName.Keys.ToList();

            MessageBox.Show("Data grab is complete!\nPress OK to continue...");

            
            


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            double[] dataArrayForSelectedWorker = null;
            double total = 0;
            grabDataFor(nameListBox.SelectedValue.ToString(), ref dataArrayForSelectedWorker);

            for (int i = 0; i < dataArrayForSelectedWorker.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, dataArrayForSelectedWorker[i]);
                chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Circle;
                chart1.Series[0].Points[i].MarkerSize = 10;
                chart1.Series[0].Points[i].MarkerColor = Color.Blue;

                total += dataArrayForSelectedWorker[i];
            }
            
            totalHoursLabel.Text = "Total Hours: " + total;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisY.Title = "Hours";
            chart1.Series[0].LegendText = "Hours Worked";
            String[] lines;
            if (File.Exists(@"userData.txt") == true)
            {
                lines = System.IO.File.ReadAllLines(@"userData.txt");
                if (lines[0] != null)
                    usernameBox.Text = lines[0];
                if (lines[1] != null)
                    passwordBox.Text = lines[1];
            }
        }

        public int findMinutes(String startTime, String endTime)
        {
            int startHours = 0, startMinutes = 0, endHours = 0, endMinutes = 0;
            if (startTime.Contains("NOON"))
            {
                startHours = 12;
                startMinutes = 0;
            }
            else if(startTime.Contains("MIDNIGHT"))
            {
                startHours = 24;
                startMinutes = 0;
            }
            else
            {
                startHours = Convert.ToInt32(startTime.Substring(0, startTime.IndexOf(':')));
                startMinutes = Convert.ToInt32(startTime.Substring(startTime.IndexOf(':') + 1, 2));
                if (startTime.Contains("PM"))
                    startHours += 12;
            }

            if (endTime.Contains("NOON"))
            {
                endHours = 12;
                endMinutes = 0;
            }
            else if (endTime.Contains("MIDNIGHT"))
            {
                endHours = 0;
                endMinutes = 0;
            }
            else
            {


                endHours = Convert.ToInt32(endTime.Substring(0, endTime.IndexOf(':')));
                endMinutes = Convert.ToInt32(endTime.Substring(endTime.IndexOf(':') + 1, 2));
                if (endTime.Contains("PM"))
                    endHours += 12;
            }

            startMinutes += 60 * startHours;
            endMinutes += 60 * endHours;

            //flag for PM to AM switch
            
            //check if there is an PM to AM switch or full day
            if(endMinutes - startMinutes <= 0)
            {
                endMinutes += 1440;
            }
            //returns for calulated amount of minutes
            return endMinutes - startMinutes; 
        }

        private void excelExport_Click(object sender, EventArgs e)
        {/*
            String[] jobsData = new String[jobs.Count];
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "Virginia Tech Production Services";
                oSheet.Cells[2, 1] = "Shift Name";
                oSheet.Cells[2, 2] = "Shift Date";
                oSheet.Cells[2, 3] = "Shift Staff";
                oSheet.Cells[2, 4] = "Time Scheduled";
                oSheet.Cells[1, 4] = "Number of Shifts: " + jobs.Count;
                int row = 4;
                foreach (Job j in jobs)
                {
                    oSheet.Cells[row, 1] = j.getJobName();
                    oSheet.Cells[row, 2] = j.getJobDateTime().ToString("dddd, dd MMMM yyyy");
                    foreach (Person w in j.getWorkers())
                    {
                        oSheet.Cells[row, 3] = w.getFirstName() + " " + w.getLastName();
                        oSheet.Cells[row, 4] = w.getFormattedTime(w.getStartTime()) + " - " + w.getFormattedTime(w.getEndTime());
                        row += 1;
                    }
                    row += 1;
                }


                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("A2", "D2").Font.Underline = true;
                oSheet.get_Range("A2", "D2").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                // Create an array to multiple values at once.
                string[,] saNames = new string[5, 2];

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "J1");
                oRng.EntireColumn.AutoFit();
                oXL.Visible = true;
                oXL.UserControl = true;
            }
            catch
            {

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the start and end dates, enter a CEP username and password, and press submit.\n" +
                "To update the chart to the selected person's data, press update chart.\n\n\n" +
                "Created by Greg Fairbanks and Matthew Bocharnikov.\n\n" +
                "For use at Virginia Tech Production Services.");
        }

        private void grabDataFor(String name, ref double[] dataArray)
        {
            int curIndex = indexByName[name], iCount = 0;
            //makes array for days

            //if day is selected
            if (analysisTypeListBox.SelectedIndex == 0)
                iCount = (endDate.Value.Date - startDate.Value.Date).Days + 1;
            //if month is selected
            else if (analysisTypeListBox.SelectedIndex == 1)
                iCount = (endDate.Value.Year - startDate.Value.Year) * 12 + (endDate.Value.Month - startDate.Value.Month) + 1;
            //if year is selected
            else if (analysisTypeListBox.SelectedIndex == 2)
                iCount = (endDate.Value.Year - startDate.Value.Year) + 1;
            else
                return; //do noting maybe throw error

            if (iCount != 0)
                dataArray = new double[iCount];

            //make data array
            for (int i = 0; i < iCount; i++)
            {
                //if day is selected
                if (analysisTypeListBox.SelectedIndex == 0)
                {
                    dataArray[i] = minutesPerWorkerByDay[curIndex] / 60;
                    chart1.ChartAreas[0].AxisX.Title = "Days";
                }
                //if month is selected
                else if (analysisTypeListBox.SelectedIndex == 1)
                {
                    dataArray[i] = minutesPerWorkerByMonth[curIndex] / 60;
                    chart1.ChartAreas[0].AxisX.Title = "Months";
                }
                //if year is selected
                else if (analysisTypeListBox.SelectedIndex == 2)
                {
                    dataArray[i] = minutesPerWorkerByYear[curIndex] / 60;
                    chart1.ChartAreas[0].AxisX.Title = "Years";
                }
                else
                    dataArray[i] = 0;

                //update the current index
                curIndex += indexByName.Count;
            }

        }

        //returns a set of ints representing order from greatest to least of indexes of names
        private int[] findOverLimit(int totalDays)
        {
            int[] totalHoursPerWorker = new int[indexByName.Count - 1], tempOverWorkers = new int[indexByName.Count - 1], overWorkers;
            int totalOver = 0;

            totalWorkerHoursByDay(ref totalHoursPerWorker, totalDays);

            //check for how many are over the limit
            for(int j = 0; j < totalHoursPerWorker.Length; j++)
            {
                if (totalHoursPerWorker[j] >= 40 * 60)
                {
                    tempOverWorkers[j] = j;
                    totalOver++;
                }
                else
                {
                    tempOverWorkers[j] = -1;
                }
                  
            }

            overWorkers = new int[totalOver];

            for(int r = 0; r < tempOverWorkers.Length; r++)
            {
                if (tempOverWorkers[r] != -1)
                {
                    overWorkers[totalOver - 1] = r + 1;
                    totalOver--;
                }
            }

            return overWorkers;
        }

        private void HoursCheck_Click(object sender, EventArgs e)
        {
            if (totalDays == 7 && analysisTypeCheckBoxList.GetItemChecked(0))
            {
                checkerListView.Clear();
                checkerListView.Scrollable = true;
                checkerListView.View = View.Details;

                checkerListView.Columns.Add("Name");
                checkerListView.Columns.Add("Hours Needed");

                int[] tempWorkers = orderByHoursNeeded(totalDays), tempHours = new int[indexByName.Count - 1];
                totalWorkerHoursByDay(ref tempHours, totalDays);
                string[] names = new string[tempWorkers.Length], hours = new string[tempHours.Length];


                double temp;

                for (int i = 0; i < tempWorkers.Length; i++)
                {

                    checkerListView.Items.Add(getKeyByValue(tempWorkers[i]));

                    temp = (double)(tempHours[tempWorkers[i] - 1] / 60);
                    if (temp > 8)
                    {
                        temp = 0;
                    }
                    else
                    {
                        temp = 8 - temp;
                    }
                    checkerListView.Items[i].SubItems.Add(temp.ToString("0.##"));
                }
                checkerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                checkerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                checkerListView.GridLines = true;
            }
            else
            {
                MessageBox.Show("To use this feature follow the steps below:\n-Select a one week period\n-Ensure that Day is selected for analysis type\n-Click submit to update the software", "Invalid Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OvertimeCheck_Click(object sender, EventArgs e)
        {
            if (totalDays == 7 && analysisTypeCheckBoxList.GetItemChecked(0))
            {

                checkerListView.Clear();
                checkerListView.Scrollable = true;
                checkerListView.View = View.Details;

                checkerListView.Columns.Add("Name");
                checkerListView.Columns.Add("Total Hours");

                int[] overWorkers = findOverLimit(totalDays), totalHours = new int[indexByName.Count - 1];
                totalWorkerHoursByDay(ref totalHours, totalDays);
                double temp;

                for (int i = 0; i < overWorkers.Length; i++)
                {

                    checkerListView.Items.Add(getKeyByValue(overWorkers[i]));

                    temp = (double)(totalHours[overWorkers[i] - 1] / 60);

                    checkerListView.Items[i].SubItems.Add(temp.ToString("0.##"));
                }

                checkerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                checkerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                checkerListView.GridLines = true;
            }
            else
            {
                MessageBox.Show("To use this feature follow the steps below:\n-Select a one week period\n-Ensure that Day is selected for analysis type\n-Click submit to update the software", "Invalid Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int[] orderByHoursNeeded(int totalDays)
        {
            int[] totalHoursPerWorker = new int[indexByName.Count - 1], orderedLToGHourTotal = new int[indexByName.Count - 1];
            totalWorkerHoursByDay(ref totalHoursPerWorker, totalDays);
            int tempMinIndex, orderedArrayIndex = 0;
            //orderedLToGHourTotal = totalHoursPerWorker;

            for (int i = 0; i < totalHoursPerWorker.Length; i++)
            {
                tempMinIndex = totalHoursPerWorker.Length - 1;
                for (int j = 0; j < totalHoursPerWorker.Length; j++)
                {
                    if(totalHoursPerWorker[j] != -1)
                    {
                        tempMinIndex = j;
                        break;
                    }
                }

                for (int k = 0; k < totalHoursPerWorker.Length; k++)
                {
                    if (totalHoursPerWorker[tempMinIndex] > totalHoursPerWorker[k] && totalHoursPerWorker[k] != -1)
                        tempMinIndex = k;
                }
                totalHoursPerWorker[tempMinIndex] = -1;

                orderedLToGHourTotal[orderedArrayIndex] = tempMinIndex + 1;
                orderedArrayIndex++;
            }
            return orderedLToGHourTotal;
        }

        private void totalWorkerHoursByDay(ref int[] totalHoursPerWorker, int totalDays)
        {
            for (int i = 1; i < indexByName.Count; i++)
            {
                for (int k = 0; k < totalDays; k++)
                {
                    totalHoursPerWorker[i - 1] += minutesPerWorkerByDay[i + (k * indexByName.Count)];
                }
            }
        }
            
        //returns the key from the value of the dictionary
        private string getKeyByValue(int value)
        {
            foreach(String name in indexByName.Keys)
            {
                if (indexByName[name] == value)
                    return name;
            }
            //if not found return nothing
            return "";
        }
    }

}

