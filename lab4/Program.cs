using System;

namespace lab4
{
    class ComplexNum
    {
        public readonly double real;
        public readonly double im;
        public ComplexNum()
        {
            real = 0;
            im = 0;
        }
        public ComplexNum(double re)
        {
            real = re;
            im = 0;
        }
        public ComplexNum(double re, double img)
        {
            real = re;
            im = img;
        }
        public static ComplexNum operator +(ComplexNum num1, ComplexNum num2)
        {
            return new ComplexNum(num1.real + num2.real, num1.im + num2.im);
        }
        public static ComplexNum operator -(ComplexNum num1, ComplexNum num2)
        {
            return new ComplexNum(num1.real - num2.real, num1.im - num2.im);
        }
        public static ComplexNum operator /(ComplexNum num1, ComplexNum num2)
        {
            return new ComplexNum((num1.real * num2.real + num1.im * num2.im) / (Math.Pow(num2.real, 2) + Math.Pow(num2.im, 2)),
                (num2.real * num1.im - num1.real * num2.im) / (Math.Pow(num2.real, 2) + Math.Pow(num2.im, 2)));
        }
        public static ComplexNum operator *(ComplexNum num1, ComplexNum num2)
        {
            return new ComplexNum(num1.real * num2.real - num1.im * num2.im, num1.real * num2.im + num1.im * num2.real);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNum num1 = new ComplexNum(1, 2),
                num2 = new ComplexNum(2, 1);
            Console.WriteLine((num1 + num2).im); // и так далее короче
        }
    }
}
