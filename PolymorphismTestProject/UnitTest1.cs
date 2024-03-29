﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;

namespace PolymorphismTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee employee = new Employee();

            string expectedResponse = String.Format("This ANGRY EMPLOYEE worked {0} hrs. " +
                            "Paid for 40 hrs at $ {1}" +
                            "/hr = ${2}", weeklyHours, wage, salary);

            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursReturns3850Dollars()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor employee = new Contractor();

            string expectedResponse = String.Format("This HAPPY CONTRACTOR worked {0} hrs. " +
                            "Paid for {0} hrs at $ {1}" +
                            "/hr = ${2} ", weeklyHours, wage, salary);

            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreEqual(response, expectedResponse);
        }
    }
}
