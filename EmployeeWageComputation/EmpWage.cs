using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWage
    {
        //static variables
        const int WAGE_PER_HR = 20;
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        const int WORKING_DAYS_IN_MONTH = 20;
        const int MAX_WORKING_HRS = 100;
        public void WageComputation()//method to calculate employee wage
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalDays = 0;
            while (totalEmpHrs <= MAX_WORKING_HRS && totalDays < WORKING_DAYS_IN_MONTH)
            {
                totalDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)

                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;


                }
                totalEmpHrs = totalEmpHrs + empHrs;
                int totalWage = totalEmpHrs * WAGE_PER_HR;
                Console.WriteLine("Total Employee Wage :" + totalWage);
            }
            
           
        }
    }
}