﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        //INFO: po kazdom refactoringu vykonat pretestovanie
        const int HoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            decimal annualSalary = hourlyWage * HoursInYear;
            return annualSalary;
        }

        public decimal GetHourlyWage(int annualSalary)
        {
            return annualSalary / (decimal)HoursInYear;
        }
    }
}
