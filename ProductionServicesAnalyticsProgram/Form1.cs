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
        //Array for holding the dates of the selections
        DateTime[] dates;

        //Array for holding the worker information
        Worker[] workers;

        //2D array of working times where the rows are dates and the columns are workers
        //The elements are the times that are worked by each worker on each date
        WorkingTime[,] workingTimes;

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //execute data grab in background
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;

            //run background process
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
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
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 5000;
            toolTip1.ReshowDelay = 1000;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.chart1, "Select a name to view data.");
        }

        //export total hours for a certain period within the searched criteria to an excel file
        private void excelExport_Click(object sender, EventArgs e)
        {
            /*
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

            }
            */
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the start and end dates, enter a CEP username and password, and press submit.\n" +
                "To update the chart to the selected person's data, press update chart.\n\n\n" +
                "Created by Greg Fairbanks and Matthew Bocharnikov.\n\n" +
                "For use at Virginia Tech Production Services.");
        }
       
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //for keeping track of completion of process
            double progressBarCompletion = 0;

            //reports process completion percentage
            backgroundWorker1.ReportProgress((int)progressBarCompletion);

            //stores username and password data in text file as well as prefills the appropriate textbox for user ease
            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                System.IO.File.WriteAllLines(@"userData.txt", new string[] { usernameBox.Text, passwordBox.Text });
            }
            String user = usernameBox.Text;
            String pass = passwordBox.Text;

            //calculating the time difference in days and normalizing the answer
            TimeSpan diff = startDate.Value - endDate.Value;
            int totalDays = (int)diff.TotalDays;
            if (totalDays < 0)
                totalDays *= -1;
            //to account for inclusive of start date and exclusive of end date
            totalDays++;

            //find progress bar increment value
            double progressBarIncrement = 90.0 / totalDays;

            DateTime currentDate = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day);

            //initializes the dates array
            dates = new DateTime[totalDays];

            //runs the selenium Chrome driver and uses it
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");

            //updates progress bar
            progressBarCompletion += 2;
            if (progressBarCompletion > 99)
                progressBarCompletion = 99;
            if (progressBarCompletion <= 99)
                backgroundWorker1.ReportProgress((int)progressBarCompletion);

            //selenium driver process
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
        
            //updates the progress bar
            progressBarCompletion += 3;
            if (progressBarCompletion > 99)
                progressBarCompletion = 99;
            if (progressBarCompletion <= 99)
                backgroundWorker1.ReportProgress((int)progressBarCompletion);

            //grabs live info from the CEP page to get realistic data for exomployees
            IReadOnlyCollection<IWebElement> elements;
            driver.Url = "http://172.21.20.41/cepdotnet/CEPemployeeSearch.aspx";
            elements = driver.FindElements(By.ClassName("CEPSub"));

            String tempEmployeeInfo = "", tempFirstName = "", tempLastName = "";

            workingTimes = new WorkingTime[totalDays, elements.Count];
            workers = new Worker[elements.Count];

            int tempWorkerIndex = 0;
            foreach (IWebElement employerInfo in elements)
            {
                tempEmployeeInfo = getUntilNumber(employerInfo.Text);
                tempLastName = tempEmployeeInfo.Substring(0, tempEmployeeInfo.IndexOf(",")).TrimStart().TrimEnd();
                tempFirstName = tempEmployeeInfo.Substring(tempEmployeeInfo.IndexOf(",") + 1).TrimStart().TrimEnd();
                workers[tempWorkerIndex] = new Worker(tempFirstName, tempLastName);
                tempWorkerIndex++;
            }

            //temp variables for schedule analysis
            String[] tempElementArray;
            String tempString, tempStringData;
            DateTime tempStart, tempEnd;
            int tempHours, tempMinutes;

            //updates progess bar
            progressBarCompletion += 5;
            if (progressBarCompletion > 99)
                progressBarCompletion = 99;
            if (progressBarCompletion <= 99)
                backgroundWorker1.ReportProgress((int)progressBarCompletion);

            for (int currentDateIndex = 0; currentDateIndex < totalDays; currentDateIndex++)
            {
                //update the webpage for analysis
                driver.Url = "http://172.21.20.41/cepdotnet/CEPHome.aspx?day=" + currentDate.Day.ToString() + "&month=" + currentDate.Month.ToString() + "&year=" + currentDate.Year.ToString();

                dates[currentDateIndex] = currentDate;

                //grabs all events for current selected day
                elements = driver.FindElements(By.ClassName("CEPDaySub"));

                foreach (IWebElement element in elements)
                {
                    //data on individual workers starting at index 3 (inclusive)
                    tempElementArray = element.Text.Split('\n');
                    for (int i = 3; i < tempElementArray.Length; i++)
                    {
                        //isolates the string with data
                        tempStringData = tempElementArray[i].TrimStart().TrimEnd();

                        //isolates the first and last name with a space in between
                        tempString = tempStringData.Substring(0, getIndexOfTime(tempStringData)).TrimStart().TrimEnd();

                        tempFirstName = tempString.Substring(0, tempString.IndexOf(" "));
                        tempLastName = tempString.Substring(tempString.IndexOf(" ") + 1);

                        //isolate the the times
                        tempStringData = tempStringData.Substring(getIndexOfTime(tempStringData));

                        //isolate the start time
                        if (tempStringData.IndexOf("NOON") == 0)
                        {
                            tempStart = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 12, 0, 0);
                            tempStringData = tempStringData.Substring(4).TrimStart();
                        }

                        //very unlikely for a time to start at midnight
                        else if (tempStringData.IndexOf("MIDNIGHT") == 0)
                        {
                            tempStart = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 0, 0, 0);
                            tempStart.AddDays(1);
                            tempStringData = tempStringData.Substring(8).TrimStart();
                        }

                        //for time cases without letters
                        else
                        {
                            tempString = tempStringData.Substring(0, tempStringData.IndexOf(":"));
                            tempStringData = tempStringData.Substring(tempStringData.IndexOf(":") + 1);
                            tempHours = Int32.Parse(tempString);

                            //isolates the minutes
                            tempString = tempStringData.Substring(0, 2);
                            tempMinutes = Int32.Parse(tempString);

                            //isolate the AM or PM
                            tempStringData = tempStringData.Substring(2).TrimStart();

                            tempString = tempStringData.Substring(0, 2);
                            if (tempString.Equals("PM") && tempHours!= 12)
                                tempHours += 12;
                           


                            tempStart = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, tempHours, tempMinutes, 0);

                            tempStringData = tempStringData.Substring(2).TrimStart();

                        }

                        //time case for NOON
                        if (tempStringData.IndexOf("NOON") == 0)
                        {
                            tempEnd = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 12, 0, 0);
                        }

                        //time case for MIDNIGHT
                        else if (tempStringData.IndexOf("MIDNIGHT") == 0)
                        {
                            tempEnd = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 0, 0, 0);
                            tempEnd.AddDays(1);
                        }

                        //time case for times with no letters
                        else
                        {
                            tempString = tempStringData.Substring(0, tempStringData.IndexOf(":"));
                            tempStringData = tempStringData.Substring(tempStringData.IndexOf(":") + 1);
                            tempHours = Int32.Parse(tempString);

                            //isolates the minutes
                            tempString = tempStringData.Substring(0, 2);
                            tempMinutes = Int32.Parse(tempString);

                            //isolate the AM or PM
                            tempStringData = tempStringData.Substring(2).TrimStart();

                            tempString = tempStringData.Substring(0, 2);
                            if (tempString.Equals("PM") && tempHours != 12)
                                tempHours += 12;

                            tempEnd = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, tempHours, tempMinutes, 0);
                        }

                        //grabs the event name
                        tempString = tempElementArray[0];
                        if (tempString.Contains("\r"))
                            tempString = tempString.Substring(0, tempString.Length - 1);

                        //creates a WorkingTime object in 2D array
                        if (workingTimes[currentDateIndex, findWorkerIndex(tempFirstName, tempLastName)] == null)
                            workingTimes[currentDateIndex, findWorkerIndex(tempFirstName, tempLastName)] = new WorkingTime(tempString, tempStart, tempEnd);
                        else
                            workingTimes[currentDateIndex, findWorkerIndex(tempFirstName, tempLastName)].addWorkTimes(tempStart, tempEnd);

                    }

                }

                //updates the current date
                currentDate = currentDate.AddDays(1);

                //update the progress bar
                progressBarCompletion += progressBarIncrement;
                if (progressBarCompletion > 99)
                    progressBarCompletion = 99;
                if (progressBarCompletion <= 99)
                    backgroundWorker1.ReportProgress((int)progressBarCompletion);
            }

            
            //quits driver and calculates the total minutes of each worker
            driver.Quit();
            setAllWorkerTotalMinutes();

            //finish up progress bar
            while (progressBarCompletion < 100)
            {
                progressBarCompletion++;
                if (progressBarCompletion > 100)
                    progressBarCompletion = 100;
                backgroundWorker1.ReportProgress((int)progressBarCompletion);
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //update progress bar and label
            progressBar1.Value = e.ProgressPercentage;
            percentageLabel.Text = "Grabbing data...\n" + e.ProgressPercentage.ToString() + " %";
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            percentageLabel.Text = "Complete";

            //this entire section is for figuring out the overlapped workers and the times that are overlapping each day
            String[] names = new String[workers.Length], overlappedWorkers = new String[workers.Length];
            int overlappedWorkersCount = 0;

            for (int i = 0; i < workers.Length; i++)
            {
                names[i] = workers[i].getFirstName() + " " + workers[i].getLastName();
            }
            nameListBox.DataSource = names;

            for (int currentDateIndex = 0; currentDateIndex < dates.Length; currentDateIndex++)
            {
                for (int k = 0; k < workers.Length; k++)
                {
                    if (workingTimes[currentDateIndex, findWorkerIndex(workers[k].getFirstName(), workers[k].getLastName())] != null)
                    {
                        for (int h = 0; h < workingTimes[currentDateIndex, findWorkerIndex(workers[k].getFirstName(), workers[k].getLastName())].getOverlapFlags().Length; h++)
                        {
                            if (workingTimes[currentDateIndex, findWorkerIndex(workers[k].getFirstName(), workers[k].getLastName())].getOverlapFlags()[h] == 1)
                            {
                                if (!checkForValueInStringArray(overlappedWorkers, overlappedWorkersCount, workers[k].getFirstName() + " " + workers[k].getLastName()))
                                {
                                    overlappedWorkers[overlappedWorkersCount] = workers[k].getFirstName() + " " + workers[k].getLastName();
                                    overlappedWorkersCount++;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            String[] tempOverlappedWorkers = new String[overlappedWorkersCount];
            for (int f = 0; f < overlappedWorkersCount; f++)
            {

                tempOverlappedWorkers[f] = overlappedWorkers[f];
            }

            overlapNameListBox.DataSource = tempOverlappedWorkers;
        }

        //returns a string up until any number
        private String getUntilNumber(String text)
        {
            String tempInfo = "";
            foreach (char c in text)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    break;
                else
                    tempInfo += c.ToString();
            }
            return tempInfo;
        }

        //checks for a non-student worker
        //This is for future debugging, not vital
        private bool checkIfZWorker(String text)
        {
            if (text.Contains("Z-") || text.Contains("Z -") || text.Contains("z-") || text.Contains("z -"))
                return true;
            return false;
        }

        private int findWorkerIndex(String firstName, String lastName)
        {
            //finds the index of the worker based on name, returns -1 if not found
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].getFirstName().Equals(firstName) && workers[i].getLastName().Equals(lastName))
                    return i;
            }
            return -1;
        }

        private void overtimeCheckButton_Click(object sender, EventArgs e)
        {
            int dateIndex, maxSpan = 7, tempTotal;
            DateTime dateCheck = overtimeDatePicker.Value;
            dateCheck = dateCheck.AddDays(7);

            //checks if valid selection
            if (dateCheck.CompareTo(endDate.Value) >= 0)
            {
                MessageBox.Show("Choose a date between (including start date)\nthe start and end date selected.\nEnsure that the date selection is at least 8 days apart\nand that the selected date for checking for overtime workers is\nat least 8 days from the end date selection.");
                return;
            }

            dateIndex = getIndexFromDate(overtimeDatePicker.Value);

            //checks for overtime workers
            for (int w = 0; w < workers.Length; w++)
            {
                tempTotal = 0;
                for (int d = 0; d < maxSpan; d++)
                {
                    if (workingTimes[dateIndex + d, w] != null)
                        tempTotal += workingTimes[dateIndex + d, w].getWorkerTotalMinutes();
                }
                if (tempTotal >= 2400)
                {
                    overtimeNameListBox.Items.Add(workers[w].getFirstName() + " " + workers[w].getLastName());
                }
            }
        }

        private void overtimeNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //updates the information beside the selection box
            //updates on selection
            overtimeInformationView.Items.Clear();

            int dateIndex, maxSpan = 8, tempTotal;
            double totalHours = 0;
            String fN = overtimeNameListBox.SelectedItem.ToString().Substring(0, overtimeNameListBox.SelectedItem.ToString().IndexOf(" "));
            String lN = overtimeNameListBox.SelectedItem.ToString().Substring(overtimeNameListBox.SelectedItem.ToString().IndexOf(" ") + 1);


            int w = findWorkerIndex(fN, lN);

            dateIndex = getIndexFromDate(overtimeDatePicker.Value);
            bool extraSpace = false;

            tempTotal = 0;
            for (int d = 0; d < maxSpan; d++)
            {
                if (workingTimes[dateIndex + d, w] != null)
                {

                    tempTotal += workingTimes[dateIndex + d, w].getWorkerTotalMinutes();
                    String[] temp = workingTimes[dateIndex + d, w].getEventNames();

                    for (int i = 0; i < temp.Length; i++)
                    {
                        overtimeInformationView.Items.Add(temp[i]);
                        overtimeInformationView.Items.Add(dates[dateIndex + d].ToString("dddd, dd MMMM yyyy"));
                        overtimeInformationView.Items.Add("");
                        extraSpace = true;
                    }

                }


            }

            if (extraSpace)
            {
                //adds extra space
                overtimeInformationView.Items.Add("");
                overtimeInformationView.Items.Add("");
            }
            totalHours = tempTotal / 60.0;
            overtimeInformationView.Items.Add("Total Hours: " + totalHours);

        }

        //gets the index of any sort of time parameter found in string extracted from CEP
        private int getIndexOfTime(String text)
        {
            int i1 = 10000, i2 = 0;
            if (text.Contains("NOON"))
                i1 = text.IndexOf("NOON");
            if (text.Contains("MIDNIGHT") && i1 > text.IndexOf("MIDNIGHT") && text.IndexOf("MIDNIGHT") != -1)
                i1 = text.IndexOf("MIDNIGHT");

            foreach (char c in text)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    break;
                else
                    i2++;
            }

            if (i1 < i2)
                return i1;
            else
                return i2;
        }

        //sets the total worker minutes for each worker
        private void setAllWorkerTotalMinutes()
        {
            for (int i = 0; i < workingTimes.GetLength(0); i++)
            {
                for (int k = 0; k < workers.Length; k++)
                {
                    if (workingTimes[i, k] != null)
                    {
                        workers[k].setTotalMinutes(workingTimes[i, k].getWorkerTotalMinutes());
                    }
                }
            }
        }

        //grabs the index of the date specified
        private int getIndexFromDate(DateTime date)
        {
            for (int i = 0; i < dates.Length; i++)
            {
                if (dates[i].Year == date.Year && dates[i].Month == date.Month && dates[i].Day == date.Day)
                    return i;
            }
            return -1;
        }

        //updates chart on name selection instead of update button
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            double[] dataArrayForSelectedWorker = new double[dates.Length];
            double total = 0;
            //grabDataFor(nameListBox.SelectedValue.ToString(), ref dataArrayForSelectedWorker);

            String firstName = nameListBox.SelectedValue.ToString().Substring(0, nameListBox.SelectedValue.ToString().IndexOf(" "));
            String lastName = nameListBox.SelectedValue.ToString().Substring(nameListBox.SelectedValue.ToString().IndexOf(" ") + 1);
            int workerIndex = findWorkerIndex(firstName, lastName);

            for (int d = 0; d < dates.Length; d++)
            {
                if (workingTimes[d, workerIndex] != null)
                    dataArrayForSelectedWorker[d] = workingTimes[d, workerIndex].getWorkerTotalMinutes() / 60.0;
                else
                    dataArrayForSelectedWorker[d] = 0;
            }

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

        //check for repeating values in overlapping string array
        private bool checkForValueInStringArray(String[] arr, int maxIndex, String val)
        {
            for(int i = 0; i < maxIndex; i++)
            {
                if (arr[i].Equals(val))
                    return true;
            }
            return false;
        }

        //updates the overlap information on name click
        private void overlapNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            overlapInformationView.Items.Clear();
            int workerIndex = findWorkerIndex(overlapNameListBox.SelectedValue.ToString().Substring(0, overlapNameListBox.SelectedValue.ToString().IndexOf(" ")), overlapNameListBox.SelectedValue.ToString().Substring(overlapNameListBox.SelectedValue.ToString().IndexOf(" ") + 1));
            WorkingTime tempWorkingTime;

            for (int d = 0; d < dates.Length; d++)
            {
                tempWorkingTime = workingTimes[d, workerIndex];

                if (tempWorkingTime != null)
                {
                    overlapInformationView.Items.Add(dates[d].ToString("dddd, dd MMMM yyyy"));

                    for (int i = 0; i < tempWorkingTime.getOverlapFlags().Length; i++)
                    {

                        if (tempWorkingTime.getOverlapFlags()[i] == 1)
                        {
                            overlapInformationView.Items.Add(tempWorkingTime.getEventNames()[i]);
                            overlapInformationView.Items.Add("Start Time: " + tempWorkingTime.getStartTimes()[i].ToString("h:mm tt"));
                            overlapInformationView.Items.Add("End Time: " + tempWorkingTime.getEndTimes()[i].ToString("h:mm tt"));
                            overlapInformationView.Items.Add("");
                        }

                    }
                    overlapInformationView.Items.Add("");
                    overlapInformationView.Items.Add("");
                }

            }
        }
    }
}

