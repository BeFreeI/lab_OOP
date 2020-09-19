using System;

namespace lab1 {
    class Program {
        delegate double func(double x);
        private static double fiveVarZ1(double a) {
            return 1 - (1 / 4) * Math.Pow(Math.Sin(2 * a), 2) + Math.Cos(2 * a);
        }
        private static double fiveVarZ2(double a)
        {
            return Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(a), 4);
        }
        static void Main(string[] args) {
            double a = 0,
                b = 10,
                h = 1;
            for(double i = a; i <= b; i += h)
            {
                Console.WriteLine("a = " + i);
                Console.WriteLine("z1 = " + CalcFx(fiveVarZ1, i));
                Console.WriteLine("z2 = " + CalcFx(fiveVarZ2, i));
            }
        }
        private static double CalcFx(func fx, double x) {
            return fx(x);
        }
    }
}
