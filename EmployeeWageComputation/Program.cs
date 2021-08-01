using System;
using System.Collections.Generic;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompany();
            empWageBuilder.Wage();


        }
    }
}
