using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWage
    {
        //static variables
        const int WAGE_PER_HR = 20;
        const int FULL_TIME_HR = 8;
        const int PART_TIME_HR = 4;
        public void WageComputation()//method to calculate employee wage
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                int total = WAGE_PER_HR * FULL_TIME_HR;
                Console.WriteLine("Employee Wage :" + total);
            }
            else
            {
                int total = WAGE_PER_HR * PART_TIME_HR;
                Console.WriteLine("Employee Wage :" + total);
            }
        }
    }
}
