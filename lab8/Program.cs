using System;

namespace lab8
{
    class EightNum
    {
        private string num;
        public EightNum()
        {
            num = "0";
        }
        public EightNum(string number)
        {
            foreach(char el in number)
            {
                if (Convert.ToInt32(el) >= 7)
                {
                    throw new Exception("Unexpected character");
                }
            }
            num = number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32("4") == 4);
        }
    }
}
