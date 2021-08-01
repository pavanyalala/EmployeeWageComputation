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
        public static int empWorkHr;
        public static int totalDays = 0;
        public static int totalHrs = 0;
        public static List<WageForCompany> CompaniesList = new List<WageForCompany>();
        /// <summary>
        /// Method will add company details
        /// </summary>
        public void AddCompany()
        {
            WageForCompany wageForCompany = new WageForCompany();
            Console.WriteLine("Enter How many companies to be added");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Enter Name of the Company");
                wageForCompany.CompanyName = Console.ReadLine();
                Console.WriteLine("Enter the Wage per hour");
                wageForCompany.WagePerHr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter total number of working days");
                wageForCompany.WorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the maximum working hours ");
                wageForCompany.MaxWorkHr = Convert.ToInt32(Console.ReadLine());
                CompaniesList.Add(wageForCompany);
                Console.WriteLine("Company added Sucessfully");
            }
        }
        /// <summary>
        /// Checks Emloyee Status
        /// </summary>
        public void Wage()
        {
            foreach (var data in CompaniesList)
            {
                while (totalDays <= data.WorkingDays && totalHrs <= data.MaxWorkHr)
                {
                    Random random = new Random();
                    int number = random.Next(0, 2);
                    switch (number)
                    {
                        case IS_FULL_TIME:
                            empWorkHr = 8;
                            break;
                        case IS_PART_TIME:
                            empWorkHr = 4;
                            break;
                        default:
                            empWorkHr = 0;
                            break;
                    }
                    totalDays++;
                    totalHrs = totalHrs + empWorkHr;
                }
                data.TotalWage = data.WagePerHr * totalHrs;
                Display(data);
            }
        }
        /// <summary>
        /// prints total wage of company
        /// </summary>
        /// <param name="company"></param>
        public void Display(WageForCompany company)
        {

            Console.WriteLine("Total Employee Wage for company: " + company.CompanyName + "  " + company.TotalWage);
        }
    }
}
