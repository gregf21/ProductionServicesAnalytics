/*
 * Class for holding basic data for times of work and names of the events.
 * Overlap flag is for testing for overlapping work schedules
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionServicesAnalyticsProgram
{
    class WorkingTime
    {
        //everything is indexed to the same index which is the date selection
        
        //event names
        private String[] eventNames;
        
        private DateTime[] startTimes, endTimes;

        //1 means overlap on that index, 0 is opoosite
        private int[] overlapFlag;

        //current index for the time arrays
        private int timeIndex;

        public WorkingTime(String eN, DateTime start, DateTime end)
        {
            startTimes = new DateTime[1];
            startTimes[0] = start;
            endTimes = new DateTime[1];
            endTimes[0] = end;
            eventNames = new string[1];
            eventNames[0] = eN;
            overlapFlag = new int[1];
            timeIndex = 0;
        }

        //method for adding work time while seeing if there is a possible overlap and recording it
        public void addWorkTimes(String eventN, DateTime start, DateTime end)
        {
            DateTime[] temp;
            String[] tempString;

            //update the start times array
            tempString = eventNames;
            eventNames = new String[tempString.Length + 1];
            for (int i = 0; i < tempString.Length; i++)
            {
                eventNames[i] = tempString[i];
            }
            eventNames[tempString.Length] = eventN;

            //update the start times array
            temp = startTimes;
            startTimes = new DateTime[temp.Length + 1];
            for(int i = 0; i < temp.Length; i++)
            {
                startTimes[i] = temp[i];
            }
            startTimes[temp.Length] = start;

            //update the end times array
            temp = endTimes;
            endTimes = new DateTime[temp.Length + 1];
            for(int j = 0; j < temp.Length; j++)
            {
                endTimes[j] = temp[j];
            }
            endTimes[temp.Length] = end;

            //update the overlap array
            int[] tempOverlap = overlapFlag;
            overlapFlag = new int[tempOverlap.Length + 1];
            for(int k = 0; k < tempOverlap.Length; k++)
            {
                overlapFlag[k] = tempOverlap[k];
            }
            checkOverlap();

            timeIndex++;
        }

        //helper method for overlap check
        private void checkOverlap()
        {
            for(int i = 0; i < startTimes.Length; i++)
            {
                for(int j = 0; j < startTimes.Length; j++)
                {
                    if(startTimes[i].CompareTo(startTimes[j]) > 0 && startTimes[i].CompareTo(endTimes[j]) < 0)
                    { 
                        overlapFlag[i] = 1;
                        overlapFlag[j] = 1;
                    }
                }
            }
        }

        //finds the difference between two DateTime objects in minutes
        //useful for finding time worked
        public int getTimeDifferenceInMinutes(DateTime sTime, DateTime eTime)
        {
            TimeSpan diff = eTime - sTime;
            int tempTime = (int)diff.TotalMinutes;
            if (tempTime < 0)
                tempTime *= -1;
            return tempTime;
        }

        public DateTime[] getStartTimes()
        {
            return startTimes;
        }

        public DateTime[] getEndTimes()
        {
            return endTimes;
        }

        public int getWorkerTotalMinutes()
        {
            int totalMinutes = 0;
            for (int i = 0; i < startTimes.Length; i++)
            {
                totalMinutes += getTimeDifferenceInMinutes(startTimes[i], endTimes[i]);
            }
            return totalMinutes;
        }

        public String[] getEventNames()
        {
            return eventNames;
        }

        public int[] getOverlapFlags()
        {
            return overlapFlag;
        }
    }
}
