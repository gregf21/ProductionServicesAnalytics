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
        DateTime[] dates;
        Worker[] workers;
        WorkingTime[,] workingTimes;

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
    }
}
