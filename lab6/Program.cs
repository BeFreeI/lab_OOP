using System;

namespace lab6
{
    class Program
    {
        static public int StrangeTask1(int[,] arr)
        {
            int rez = 0,
                sum = 0;
            bool flag = false;
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                sum = 0;
                flag = false;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    sum += arr[i, j];
                    if(arr[i, j] < 0)
                    {
                        flag = true;
                    }
                }
                if(!flag)
                {
                    rez += sum;
                }
            }
            return rez;
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 1, -2, 3 }, { 4, 5, 6 }, { 7, 8, -9 }, { 10, 11, -12 } };
            Console.WriteLine(StrangeTask1(arr));
        }
    }
}
