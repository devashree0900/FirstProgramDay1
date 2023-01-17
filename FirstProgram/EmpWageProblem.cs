using FirstProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public class EmpWageProblem
    {
        public bool CheckPresentAbsent()
        {
            Console.WriteLine("Welcome to Employee Wage");

            //constant
            int PRESENT = 1;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Random value generated is " + empCheck);

            if (empCheck == PRESENT)
            {
                Console.WriteLine("Employee is present");
                return true;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                return false;
            }
            return false;
        }

        public int DailyEmpWage()
        {
            int empHrs = 0;
            int empWage = 0;
            int empRatePerHour = 20;

            if (CheckPresentAbsent())
            {
                empHrs = 8;
            }

            empWage = empRatePerHour * empHrs;
            Console.WriteLine("Employee Wage Per Day is: " + empWage);
            return empWage;
        }

        public void PartTimeEmpWage()
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int empRatePerHour = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            
            if(empCheck == isPartTime)
            {
               empHrs = 4;
            }
            else if(empCheck == isFullTime)
            {
               empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Employee Wage: " + empWage);

        }

        public void PartTimeEmpWageSwitchCase()
        {
            const int isPartTime = 1;
            const int isFullTime = 2;
            const int empRatePerHour = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch(empCheck)
            {
                case isPartTime:
                    empHrs = 4;
                    break;
                case isFullTime:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Employee Wage: " + empWage);

        }




        public void MonthlyWage()
        {
            const int isPartTime = 1;
            const int isFullTime = 2;
            const int empRatePerHour = 20;
            const int numOfWorkingDays = 20;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for(int day=0;day < numOfWorkingDays;day++) 
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = empHrs * empRatePerHour;
                totalEmpWage+= empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }

            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            
        }

        public void WageCalcWithCondition()
        {
            const int isPartTime = 1;
            const int isFullTime = 2;
            const int empRatePerHour = 20;
            const int numOfWorkingDays = 20;
            const int maxHrsInMonth = 100;

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while(totalEmpHrs< maxHrsInMonth && totalWorkingDays<numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs+= empHrs;
                Console.WriteLine("Days: " + totalWorkingDays + " Emp Hrs: " + empHrs);


            }

            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}
