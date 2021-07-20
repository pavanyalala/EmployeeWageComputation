using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWage
    {
        //method gives employee attendance
        public void EmpAttendance()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);// 0,1
            if(empcheck == 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
