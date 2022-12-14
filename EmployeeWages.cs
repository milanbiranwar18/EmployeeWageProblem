using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWages
    {
        public static void DailyEmployeeWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(" The Employee wage of the day is :" + empwage);
        }


        public static void EmployeeWageWithPartTime()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            if (num == IS_FULL_TIME)
            {
                emphrs = 12;
            }
            else if (num == IS_PART_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee wage of the day is :" + empwage);
        }

        
        public static void EmployeeWageUC4()
        {
             const int IS_PART_TIME = 1;
             const int IS_FULL_TIME = 2;

        int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            switch (num)
            {
                case IS_FULL_TIME:
                    emphrs = 12;
                    break;
                case IS_PART_TIME:
                    emphrs = 8;
                    break;
                default:
                    emphrs = 0;
                    break;

            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee wage of the day is :" + empwage);
        }


        
        public static void EmployeeWageofMonthUC5()
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        emphrs = 12;
                        break;
                    case IS_PART_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empwage;
                Console.WriteLine("Emp wage :" + empwage);
            }
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);

        }


        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static void EmployeeWageofMonthwithMaxHrs()
        {
            
            int emphrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        emphrs = 12;
                        break;
                    case IS_PART_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                totalEmpHrs += emphrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + emphrs);
            }

            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }

        
        public static void EmployeeWageUC()
        {
              

          int emphrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        emphrs = 12;
                        break;
                    case IS_PART_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                totalEmpHrs += emphrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + emphrs);
            }

            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);

        }

        
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int emphrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)

            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        emphrs = 12;
                        break;
                    case IS_PART_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                totalEmpHrs += emphrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + emphrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("total Emp Wage for company : " + company + "is :" + totalEmpWage);
            return totalEmpWage;

        }

    }
}
