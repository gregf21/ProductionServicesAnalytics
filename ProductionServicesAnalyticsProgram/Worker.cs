using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionServicesAnalyticsProgram
{
    class Worker
    {
        private String firstName, lastName;
        private int totalMinutes;

        public Worker(String fN, String lN)
        {
            firstName = fN;
            lastName = lN;
            totalMinutes = 0;
        }

        public void setFirstName(String fName)
        {
            firstName = fName;
        }
        public String getFirstName()
        {
            return firstName;
        }
        public void setLastName(String lName)
        {
            lastName = lName;
        }
        public String getLastName()
        {
            return lastName;
        }

        public void setTotalMinutes(int tM)
        {
            totalMinutes = tM;
        }

        public int getTotalMinutes()
        {
            return totalMinutes;
        }
    }
}
