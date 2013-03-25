using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puzzle2
{
    public class TriangleType
    {
        public static string GetType(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "ERROR";
            }
            else if (a == b && b == c)
            {
                return "EQUILATERAL";
            }
            else if (a == b || a == c || b == c)
            {
                return "ISOSCELES";
            }
            else
            {
                return "SCALENE";
            }
        }
 

    }
}
