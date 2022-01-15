using System;
using System.Collections.Generic;
using System.Text;

namespace EmpDailywages
{
    public class Working_hrs
    {
        //variables
        const int FULL_TIME = 2;
        const int PART_TIME = 1;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 2;
        const int MAX_HRS_IN_MONTH = 10;

        public void Work()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //While loop and switch case statement to check max hrs and days
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomInput = random.Next(0, 3);


                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("FullTime Employee is present");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("Part-Time employee is present");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day3:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            //total wages of emp
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }


    }
}