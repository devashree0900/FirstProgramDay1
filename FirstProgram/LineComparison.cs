using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public class LineComparison
    {
        public void LengthOfLine()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Msster Branch");

            //variables
            double x1, x2, y1, y2;

            //take user input
            Console.WriteLine("Enter coordinates of two points (x1,y1) and (x2,y2)");
            x1 = Convert.ToInt16(Console.ReadLine());
            y1 = Convert.ToInt16(Console.ReadLine());
            x2 = Convert.ToInt16(Console.ReadLine());
            y2 = Convert.ToInt16(Console.ReadLine());

            double len = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
            Console.WriteLine("Length of line is "+ len);   
        }

        public void EqualityOfLineLengths()
        {
            //variables
            double x1, x2, y1, y2;
            double a1, a2, b1, b2;

            //take user input
            Console.WriteLine("Enter coordinates of two points of first line (x1,y1) and (x2,y2)");
            x1 = Convert.ToInt16(Console.ReadLine());
            y1 = Convert.ToInt16(Console.ReadLine());
            x2 = Convert.ToInt16(Console.ReadLine());
            y2 = Convert.ToInt16(Console.ReadLine());

            double len1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("Length of first line is " + len1);

            Console.WriteLine("Enter coordinates of two points of second line (a1,b1) and (a2,b2)");
            a1 = Convert.ToInt16(Console.ReadLine());
            b1 = Convert.ToInt16(Console.ReadLine());
            a2 = Convert.ToInt16(Console.ReadLine());
            b2 = Convert.ToInt16(Console.ReadLine());

            double len2 = Math.Sqrt(Math.Pow(a1-a2, 2) + Math.Pow(b1-b2, 2));
            Console.WriteLine("Length of second line is " + len2);

            if(Equals(len1,len2))
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are unequal");
            }
        }

        public void ComparisonOfLineLengths()
        {
            //variables
            double x1, x2, y1, y2;
            double a1, a2, b1, b2;

            //take user input
            Console.WriteLine("Enter coordinates of two points of first line (x1,y1) and (x2,y2)");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            double len1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("Length of second line is " + len1);

            Console.WriteLine("Enter coordinates of two points of second line (a1,b1) and (a2,b2)");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());

            double len2 = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2));
            Console.WriteLine("Length of second line is " + len2);

            int result = len1.CompareTo(len2);
            if(result > 0)
            {
                Console.WriteLine("Line 1 length is greater.");
            }
            else if(result < 0)
            {
                Console.WriteLine("Line 2 length is greater.");
            }
            else
            {
                Console.WriteLine("Both Lines are equal.");
            }
        }

    }
}
