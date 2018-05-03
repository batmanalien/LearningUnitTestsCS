using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorProject
{
    public class SalaryCalculator
    {
        private const int HoursInYear = 2080;

        public decimal CalculateAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear;

        public decimal CalculateHourlyWage(decimal annualSalary) => annualSalary / HoursInYear;
    }
}
