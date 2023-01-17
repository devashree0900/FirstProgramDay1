using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageProblem empWage = new EmpWageProblem();
            //empWage.CheckPresentAbsent();
            //empWage.DailyEmpWage();
            //empWage.PartTimeEmpWage();
            //empWage.PartTimeEmpWageSwitchCase();
            //empWage.MonthlyWage();
            empWage.WageCalcWithCondition();

            LineComparison lineComp = new LineComparison();
            //lineComp.LengthOfLine();
            //lineComp.EqualityOfLineLengths();
            //lineComp.ComparisonOfLineLengths();

        }
    }
}
