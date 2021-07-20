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
        public void WageComputation()//method to calculate employee wage
        {
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0,3);
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
            Console.WriteLine("Employee Wage :" + empHrs*WAGE_PER_HR);
        }
    }
}
