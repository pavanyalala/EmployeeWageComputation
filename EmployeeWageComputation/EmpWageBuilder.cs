using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWageBuilder
    {
        const int IS_FULL_TIME = 0;
        const int IS_PART_TIME = 1;
        public static int payment = 0;
        public static int workHr;
        public static int totalDays = 0;
        public static int totalHrs = 0;

         public int Wage(string company, int wagePerHr, int workingDays, int maxHr)
        {
            while (totalDays <= workingDays && totalHrs <= maxHr)
            {
                Random random = new Random();
                int num = random.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        workHr = 8;
                        break;
                    case IS_PART_TIME:
                        workHr = 4;
                        break;
                    default:
                        break;
                }
                totalDays++;
                totalHrs += workHr;
            }

            payment = wagePerHr * totalHrs;
            Console.WriteLine("Total Employee Wage for company " + company + ":" + payment);
            return payment;
        }
    }
}
