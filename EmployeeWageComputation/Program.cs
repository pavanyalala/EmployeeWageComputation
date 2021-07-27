using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage empwage = new EmpWage();
            empwage.WageComputation("Dmart",20,2,10);
            empwage.WageComputation("Reliance", 10, 4, 20);


        }
    }
}
