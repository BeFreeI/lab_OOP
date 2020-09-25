using System;

namespace lab6 {
    class Program {
        static public int StrangeTask1(int[,] arr) {
            int rez = 0,
                sum = 0;
            bool flag = false;
            for (int j = 0; j < arr.GetLength(1); j++) {
                sum = 0;
                flag = false;
                for (int i = 0; i < arr.GetLength(0); i++) {
                    sum += arr[i, j];
                    if (arr[i, j] < 0) {
                        flag = true;
                    }
                }
                if (!flag) {
                    rez += sum;
                }
            }
            return rez;
        }

        static public int StrangeTask2(int[,] arr) {
            int sum = int.MaxValue,
                helpSum = 0,
                size = arr.GetLength(0);
            for (int val = 0; val < size; val++) {
                helpSum = 0;
                for(int i = val, j = 0; i >= 0; i--, j++) {
                    helpSum += Math.Abs(arr[i, j]);
                }
                sum = Math.Min(helpSum, sum);
            }
            for (int val = 1; val < size; val++) {
                helpSum = 0;
                for(int i = size - 1, j = val; j < size; j++, i--) {
                    helpSum += Math.Abs(arr[i, j]);
                }
                sum = Math.Min(helpSum, sum);
            }
            return sum;
        }

        static void Main(string[] args) {
            int[,] arr = { { 11, 12, 13, 14 }, 
                           { 21, 22, 23, 24 }, 
                           { 31, 32, 33, 34 }, 
                           { 41, 42, 43, 44 } };
            StrangeTask2(arr);
        }
    }
}
