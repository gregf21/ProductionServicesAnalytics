using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
