using System;

namespace lab2
{
    class Program
    {
        public static double firstTaskThirdLab(double x, double R)
        {
            if (x >= -4 && x < -2)
            {
                return (x + 3);
            }
            else if (x >= -2 && x < 4)
            {
                return (-0.5 * x);
            }
            else if (x >= 4 && x < 6)
            {
                return (-2);
            }
            else if (x >= 6 && x < 8)
            {
                return (-(Math.Sqrt(Math.Pow((x - 8), 2) - Math.Pow((2), 2)) + 2));
            }
            else if (x >= 8 && x < R + 8)
            {
                return (-(Math.Sqrt(Math.Pow((x - 8), 2) - Math.Pow((R), 2)) + 2));
            }
            else
            {
                return (0);
            }
        }
        public static bool isOk(double x, double y)
        {
            double R = 5;
            if (y > 0 && x > 0)
            {
                return ((R < Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) ? false : true);
            }
            else if (y < 0 && x < 0)
            {
                return ((R < Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) ? false : true);
            }
            else if (y > 0 && x < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isOk(2, 2));
        }
    }
}
