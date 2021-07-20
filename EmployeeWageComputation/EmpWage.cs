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
        const int PART_TIME=2;
        const int WORKING_DAYS_IN_MONTH = 20;
        public void WageComputation()//method to calculate employee wage
        {
            int empHrs = 0;
            int dailyWage = 0;
            int totalEmpWage = 0;
            Random random = new Random();
            for (int day = 0; day < WORKING_DAYS_IN_MONTH; day++)
            {
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

                dailyWage = empHrs * WAGE_PER_HR;
                totalEmpWage = totalEmpWage + dailyWage;
            }
            Console.WriteLine("Employee Monthly Wage :"+totalEmpWage);
        }
    }
}
