using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

    Select shift to book people for. Once selected, update available student list to signed up students.
    Check students to add to shift and click "add students to selected shift."
    Complete for as many shifts as necessary.
    Once shifts are booked, press submit to send all edited shifts to CEP.

*/


namespace ProductionServicesAnalyticsProgram
{
    public partial class Scratchpad : Form
    {
        //variables for posted shifts
        DateTime[] dates;
        Worker[] workers;
        WorkingTime[,] workingTimes;

        Shift[] openShifts;

        DateTime currentDate;

        string[] eventArray = new string[3];
        string[] studentArray = new string[2];


        public Scratchpad()
        {
            InitializeComponent();
        }

        public Scratchpad(DateTime[] dates, Worker[] workers, WorkingTime[,] workingTimes)
        {
            this.dates = dates;
            this.workers = workers;
            this.workingTimes = workingTimes;
            InitializeComponent();
        }
        private void Scratchpad_Load(object sender, EventArgs e)
        {
            events.View = View.Details;
            events.GridLines = true;
            events.FullRowSelect = true;
            events.Columns.Add("Event Name", 125);
            events.Columns.Add("Event Day", 100);
            events.Columns.Add("Event Time", 100);
            events.MultiSelect = false;
            students.View = View.Details;
            students.GridLines = true;
            students.FullRowSelect = true;
            students.Columns.Add("Student Name", 100);
            students.Columns.Add("Requested Work Time", 125);
            students.CheckBoxes = true;
            toolTip.InitialDelay = 2000;
            toolTip.SetToolTip(students, "Choose students for the selected shift.");
            toolTip.SetToolTip(events, "Select an event to view signed up students.");
            eventArray[0] = "EventTest1";
            eventArray[1] = "EventDay1";
            eventArray[2] = "EventTime1";
            ListViewItem item;
            item = new ListViewItem(eventArray);
            events.Items.Add(item);
            eventArray[0] = "EventTest2";
            eventArray[1] = "EventDay2";
            eventArray[2] = "EventTime2";
            ListViewItem item2;
            item2 = new ListViewItem(eventArray);
            events.Items.Add(item2);
            studentArray[0] = "StudentTest1";
            studentArray[1] = "StudentTime1";
            ListViewItem item3;
            item3 = new ListViewItem(studentArray);
            students.Items.Add(item3);
            studentArray[0] = "StudentTest2";
            studentArray[1] = "StudentTime2";
            ListViewItem item4;
            item4 = new ListViewItem(studentArray);
            students.Items.Add(item4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editedShifts.Items.Clear();
        }
        
        public void retrieveOpenShiftData()
        {
            //access shift data and possible worker information
            //for now there is temporary data for 3 shifts below

            Shift shift1 = new Shift("Culture Show", new DateTime(2019, 9, 9, 8, 0, 0),
                new DateTime(2019, 9, 9, 23, 0, 0), 4, 0);
            Shift shift2 = new Shift("CAV Shift", new DateTime(2019, 9, 10, 14, 0, 0),
                new DateTime(2019, 9, 10, 16, 0, 0), 1, 0);
            Shift shift3 = new Shift("Musical", new DateTime(2019, 9, 11, 7, 0, 0),
                new DateTime(2019, 9, 11, 23, 0, 0), 1, 0);
        }

        private void updatePossibleWorkers()
        {
            int openShiftLastIndex = 0;
            Worker[] tempWorkers;
            for (int openShiftIndex = 0; openShiftIndex < openShifts.Length; openShiftIndex++)
            {

                for (int i = 0; i < openShifts[openShiftIndex].getShiftPossibleWorkers().Length; i++)
                {
                    tempWorkers = openShifts[openShiftIndex].getShiftPossibleWorkers();
                    //if (//overtime or dual booking)
                }
            }
        }

        private bool checkWorkerForOvertime(Worker worker)
        {

            return true;
        }

        private bool checkWorkerForOverlap(Worker worker)
        {
            
            return true;
        }

        //returns the index from dates that matches the parameter date
        private int getIndexFromDate(DateTime date)
        {
            int counter = -1;
            for(int i = 0; i < dates.Length; i++)
            {
                if (!checkForEqualDates(date, dates[i]))
                    counter++;
                else
                    break;
            }
            return counter;
        }

        private bool checkForEqualDates(DateTime d1, DateTime d2)
        {
            if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day)
                return true;
            return false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(events.SelectedItems[0].SubItems[0].Text + " " + events.SelectedItems[0].SubItems[1].Text + " " + events.SelectedItems[0].SubItems[2].Text);
        }

        private void addToShift_Click(object sender, EventArgs e)
        {
            editedShifts.Items.Add(events.SelectedItems[0].SubItems[0].Text);
        }
    }
}
