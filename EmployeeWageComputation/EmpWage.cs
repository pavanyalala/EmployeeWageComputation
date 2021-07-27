using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        /// <summary>
        /// Using Class Method
        /// </summary>
        public void WageComputation(string company, int empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth)//method to calculate employee wage
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < noOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)

                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;


                }
                totalEmpHrs = totalEmpHrs + empHrs;
                int totalWage = totalEmpHrs * empRatePerHour;
                Console.WriteLine("Total Employee Wage :" + totalWage);
            }
            
           
        }
    }
}