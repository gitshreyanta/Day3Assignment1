using System;
using System.Collections.Generic;
using System.Text;

namespace EmpDailywages
{
    public class Dailywages
    {
        // Declared constant
        const int FULL_TIME = 1;
        const int PART_TIME = 2;

        public void wages1()
        {
            //Variables and Computation
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int totalWage = 0;
            int empHrs = 0;
            int EMP_RATE_PER_HR = 20;

            // switch case statement
            switch (empCheck)
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

            //calculate total wages
            totalWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Toatl Wage:" + totalWage);
            Console.ReadLine();
        }
    }
}
