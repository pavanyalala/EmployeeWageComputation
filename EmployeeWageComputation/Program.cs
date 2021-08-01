using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.Wage("Accenture", 10, 12, 70);
            empWageBuilder.Wage("Capgemini", 16, 17, 190);
            empWageBuilder.Wage("Infosys", 26, 18, 80);


        }
    }
}
