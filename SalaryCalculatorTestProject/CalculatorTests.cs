using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            //Arrange
            SalaryCalculator calculator = new SalaryCalculator();

            //Act
            decimal annualSallary = calculator.GetAnnualSalary(50);

            //Assert
            Assert.AreEqual(104000, annualSallary);
        }

        [TestMethod]
        public void HourlyWageTest()
        {
            //Arrange
            SalaryCalculator calculator = new SalaryCalculator();

            //Act
            decimal hourlyWage = calculator.GetHourlyWage(52000);

            //Assert
            Assert.AreEqual(25, hourlyWage);
        }
    }
}
