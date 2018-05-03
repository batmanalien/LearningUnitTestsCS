using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculatorProject;

namespace SalaryCaculatorUnitTestProject
{
    [TestClass]
    public class SalaryCalculatorUnitTest
    {
        [TestMethod]
        public void CalculateAnnualSalaryTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();

            //Act
            decimal annualSalary = sc.CalculateAnnualSalary(hourlyWage: 50);

            //Assert
            Assert.AreEqual(104000, annualSalary);
        }

        [TestMethod]
        public void CalculateHourlyWageTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();

            //Act
            decimal hourlyWage = sc.CalculateHourlyWage(annualSalary: 41600);

            //Assert
            Assert.AreEqual(20, hourlyWage);
        }
    }
}
