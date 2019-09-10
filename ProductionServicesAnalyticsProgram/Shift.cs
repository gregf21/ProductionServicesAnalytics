using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionServicesAnalyticsProgram
{
    public class Shift
    {
        private String name;
        private DateTime startTime, endTime;
        private int totalPositions, filledPositions;

        //these three arrays work off of the same index
        private Worker[] possibleWorkers;
        private DateTime[] possibleWorkerStartTimes, possibleWorkerEndTimes;
        //1 = chosen and 0 = not chosen and -1 is not available 
        private int[] chosenWorkers;

        public Shift(String n, DateTime sT, DateTime eT, int tP, int fP)
        {
            name = n;
            startTime = sT;
            endTime = eT;
            totalPositions = tP;
            filledPositions = fP;
        }

        public String getShiftName()
        {
            return name;
        }
        public DateTime getShiftStartTime()
        {
            return startTime;
        }

        public DateTime getShiftEndTime()
        {
            return endTime;
        }

        public int getShiftTotalPositions()
        {
            return totalPositions;
        }

        public int getShiftFilledPositions()
        {
            return filledPositions;
        }

        public void setShiftFilledPositions(int fP)
        {
            filledPositions = fP;
        }

        public Worker[] getShiftPossibleWorkers()
        {
            return possibleWorkers;
        }

        public DateTime[] getShiftPossibleWorkerStartTimes()
        {
            return possibleWorkerStartTimes;
        }

        public DateTime[] getShiftPossibleWorkerEndTimes()
        {
            return possibleWorkerEndTimes;
        }

        public void setPossibleWorkers(Worker[] pW)
        {
            possibleWorkers = pW;
        }

        public void setPossibleWorkerStartTimes(DateTime[] pWST)
        {
            possibleWorkerStartTimes = pWST;
        }

        public void setPossibleWorkerEndTimes(DateTime[] pWET)
        {
            possibleWorkerEndTimes = pWET;
        }

        public int[] getChosenWorkers()
        {
            return chosenWorkers;
        }

        public void setChosenWorkers(int[] cW)
        {
            chosenWorkers = cW;
        }

        public void setChosenWorkersAtIndex(int i, int value)
        {
            chosenWorkers[i] = value;
        }
    }
}
