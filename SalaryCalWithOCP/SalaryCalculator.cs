using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalWithOCP
{
    /*This looks so much better 
     * because we won’t have to change any of our current classes if our boss comes with another request 
     * about the intern payment calculation or any other as well.
     * All we have to do now is to add another class with its own calculation logic. 
     * So basically, our SalaryCalculator class is now closed for modification and opened for an extension, which is exactly what OCP states.
     */
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devCalc in _developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}
