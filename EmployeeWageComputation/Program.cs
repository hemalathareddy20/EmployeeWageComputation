using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation program");
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            { 
            case 1:
                empHrs = 4;
                break;
            case 2:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
