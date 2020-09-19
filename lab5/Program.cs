using System;
using System.Linq;

namespace lab5
{
    class Program
    {
        public static int FindMaxInArray(int[] arr)
        {
            int[] help = (int[])arr.Clone();
            Array.Sort(help);
            return help[help.Length - 1];
        }
        public static int StrangeTask2(int[] arr)
        {
            Array.Reverse(arr);
            int index = arr.Length - 1 - Array.IndexOf(arr, Array.Find<int>(arr, el => el > 0)),
                sum = 0;
            Array.Reverse(arr);
            for(int i = 0; i < index; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int[] StrangeTask3(int[] arr, int a, int b)
        {
            int[] newArr = new int[arr.Length];
            int index = 0;
            foreach(int i in arr)
            {
                if(!(Math.Abs(i) <= Math.Max(a, b) && Math.Abs(i) >= Math.Min(a, b)))
                {
                    newArr[index++] = i;
                }
            }
            return newArr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 3, 2, 1, 6, 4, 2, 21, 2, 3 };
            Console.WriteLine(FindMaxInArray(arr));
            Console.WriteLine(arr.Max());
            int[] arr1 = StrangeTask3(arr, 2, 3);
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }
            int[] arr5 = { -1, -2, -3, 3, -6, -4};
            Console.WriteLine(StrangeTask2(arr5));
        }
    }
}
