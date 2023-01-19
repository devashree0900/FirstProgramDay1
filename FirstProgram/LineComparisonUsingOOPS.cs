using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public class Line
    {
        public double x1, x2, y1, y2;
        public Line(double a1, double b1, double a2, double b2)
        {
            this.x1 = a1;
            this.x2 = b1;   
            this.y1 = b2;   
            this.y2 = a2;
        }
    }
    public class LineComparisonUsingOOPS
    {

        public double getLength(Line line)
        {
            return Math.Sqrt(Math.Pow(line.x1-line.x2,2)+Math.Pow(line.y1-line.y2,2));   
        }

        public void compare(Line line1,Line line2)
        {
            if(getLength(line1) == getLength(line2))
            {
                Console.WriteLine("Both lines are equal");
            }
            else if(getLength(line1) > getLength(line2))
            {
                Console.WriteLine("First line has a larger length");
            }
            else
            {
                Console.WriteLine("Second line has a larger length");
            }
        }
    }
}
