using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class WageForCompany
    {
        public String CompanyName { get; set; }
        public int WagePerHr { get; set; }
        public int WorkingDays { get; set; }
        public int MaxWorkHr { get; set; }
        public int TotalWage = 0;
    }
}
