using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalWithoutOCP
{
    /* 
     * this is not an optimal solution.
     * Mainly, because we had to modify our existing class behavior which worked perfectly. Another thing is that if our
     * boss comes again and ask us to modify calculation for the junior dev’s as well, we would have to change our class
     * again. This is totally against of what OCP stands for.
     */
    class CalculteSalary
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public CalculteSalary(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devReport in _developerReports)
            {
                totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            }

            return totalSalaries;
        }
    }
}
