using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalWithOCP
{
    /*
     * we are going to create two classes which will inherit from the BaseSalaryCalculator class. 
     * Because it is obvious that our calculation depends on the developer’s level,
     * we are going to create our new classes in that manner
     */
    public abstract class BaseSalaryCalculator
    {
        public DeveloperReport DeveloperReport { get; private set; }

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();

    }
}
