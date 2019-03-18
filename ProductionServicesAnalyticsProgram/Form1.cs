﻿using OpenQA.Selenium;
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

        

        public Form1()
        {
            InitializeComponent();

            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String user = "MBochar";
            String pass = "g27cp1qm";

            IWebDriver driver = new ChromeDriver();
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
            for (int dateCounter = (endDate.Value.Date - startDate.Value.Date).Days + 1; dateCounter > 0; dateCounter--)
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


            //do grab index by name
            //indexByName.FirstOrDefault(x => x.Value == i).Key + " - " + i + " : " + minutesPerWorker[i]
            

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = startDate.Value.Day;
            double[] dataArrayForSelectedWorker = null;
            double total = 0;
            grabDataFor(nameListBox.SelectedValue.ToString(), ref dataArrayForSelectedWorker);

            //loop through data and output to graph

            /* (analysisTypeCheckBoxList.SelectedIndex == 0)
            {*/
                int counter = 0;
                int i = startDate.Value.Day;
                do
                {
                    chart1.Series[0].Points.AddXY(i, dataArrayForSelectedWorker[counter]);
                    chart1.Series[0].Points[counter].MarkerStyle = MarkerStyle.Circle;
                    chart1.Series[0].Points[counter].MarkerSize = 10;
                    chart1.Series[0].Points[counter].MarkerColor = Color.Blue;
                    total += dataArrayForSelectedWorker[counter];
                    i++;
                    counter++;
                } while (counter < dataArrayForSelectedWorker.Length);
            /*}
            else if (analysisTypeCheckBoxList.SelectedIndex == 1)
            {
                 for (int i = 0; i < dataArrayForSelectedWorker.Length; i++)
                 {
                     chart1.Series[0].Points.AddXY(i+1, dataArrayForSelectedWorker[i]);
                     chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Circle;
                     chart1.Series[0].Points[i].MarkerSize = 10;
                     chart1.Series[0].Points[i].MarkerColor = Color.Blue;

                     total += dataArrayForSelectedWorker[i];
                 }
            }
            else if (analysisTypeCheckBoxList.SelectedIndex == 2)
            {
                for (int i = 0; i < dataArrayForSelectedWorker.Length; i++)
                {
                    chart1.Series[0].Points.AddXY(i + 1, dataArrayForSelectedWorker[i]);
                    chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Circle;
                    chart1.Series[0].Points[i].MarkerSize = 10;
                    chart1.Series[0].Points[i].MarkerColor = Color.Blue;

                    total += dataArrayForSelectedWorker[i];
                }
            }*/
            totalHoursLabel.Text = "Total Hours: " + total;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chart1.ChartAreas[0].AxisY.Title = "Hours";
            chart1.Series[0].LegendText = "Hours Worked";
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void filter_TextChanged(object sender, EventArgs e)
        {

        }

        private void analysisTypeCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void analysisTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        //for testing methods and functionality of specific lines
        private void debugButton_Click(object sender, EventArgs e)
        {

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
    }
}
