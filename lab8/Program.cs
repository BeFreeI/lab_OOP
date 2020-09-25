using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Security.Cryptography.X509Certificates;

namespace lab8 {
    class EightNum {
        private string num;

        public EightNum() {
            this.Num = "0";
        }

        public string Num {
            get {
                return num;
            }
            set {
                foreach (char el in value) {
                    if (el - '0' > 7 || el - '0' < 0) {
                        throw new Exception("Unexpected character");
                    }
                }
                num = value;
            }
        }

        public EightNum(string number) {
            this.Num = number;
        }

        public static Boolean operator ==(EightNum num1, EightNum num2) {
            return num1.num == num2.num;
        }

        public static Boolean operator !=(EightNum num1, EightNum num2) {
            return num1.num != num2.num;
        }

        public static Boolean operator >(EightNum num1, EightNum num2) {
            return int.Parse(num1.num) > int.Parse(num2.num);
        }

        public static Boolean operator <(EightNum num1, EightNum num2) {
            return int.Parse(num1.num) < int.Parse(num2.num);
        }

        public static Boolean operator >=(EightNum num1, EightNum num2) {
            return int.Parse(num1.num) >= int.Parse(num2.num);
        }

        public static Boolean operator <=(EightNum num1, EightNum num2) {
            return int.Parse(num1.num) <= int.Parse(num2.num);
        }

        public int ToNormalNumber() {
            char[] numStr = num.ToCharArray();
            Array.Reverse(numStr);
            int rez = 0;
            for(int i = 0; i < numStr.Length; i++) {
                rez += (numStr[i] - '0') * (int)Math.Pow(8, i);
            }
            return rez;
        }

        public char this[int i] {
            get { return num[i]; }
        }

    }

    class Program {
        static void Main(string[] args) {
            EightNum num1 = new EightNum("01234567"),
                num2 = new EightNum("1234567");
            Console.WriteLine(num2[1]);
            Console.WriteLine(num2 <= num1);
            Console.WriteLine(int.Parse(num1.Num));
            Console.WriteLine(num2.Num);
            Console.WriteLine(num2.ToNormalNumber());
        }
    }
}
