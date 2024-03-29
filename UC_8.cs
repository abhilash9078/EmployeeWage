﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class UC_8
    {
        public const int fullTime = 1;
        public const int partTime = 2;

        public static int EmployeeWage(string company, int empRatePerHour, int workingHourLimit, int empWorkingDays)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalWorkingHour = 0;
            int present = 0, halftime = 0, absent = 0;

            while (totalWorkingDays < empWorkingDays && totalWorkingHour <= workingHourLimit)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case fullTime:
                        empHrs = 8;
                        present++;
                        break;
                    case partTime:
                        empHrs = 4;
                        halftime++;
                        break;
                    default:
                        empHrs = 0;
                        absent++;
                        break;
                }
                totalWorkingHour = totalWorkingHour + empHrs;
            }
            int totalEmployeeWage = totalWorkingHour * empRatePerHour;
            Console.WriteLine("Total wage of the Employee is: " + totalEmployeeWage);
            Console.WriteLine("Total Working Hour is: " + totalWorkingHour + "Hours");
            Console.WriteLine("Employee is present for " + present + "Days");
            Console.WriteLine("Employee is Doing Partime for " + halftime + "Days");
            Console.WriteLine("Employee is Absent for " + absent + "Days");
            return totalEmployeeWage;
        }

        

        

    }
}
