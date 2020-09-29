using Microsoft.VisualBasic.CompilerServices;
using System;

namespace lab9 {
    class Program {

        class CustomString {

            public string Str { get; protected set; }
            public int Length { 
                get {
                    return this.Str.Length;
                } 
            }

            public int Word {
                get {
                    return this.Length * 2;
                }
            }

            public CustomString() {
                this.Str = "";
            }

            public CustomString(char el) {
                this.Str = el.ToString();
            }

            public CustomString(string str) {
                this.Str = str;
            }

            public void Clear() {
                this.Str = "";
            }

        }

        class BitString : CustomString {

            public BitString(string number) {
                foreach (char i in number) {
                    if (i < '0' || i > '1') {
                        throw new Exception("Unexpected character");
                    }
                }
                base.Str = number;
            }

            public void setNewValue(string number) {
                foreach (char i in number) {
                    if (i < '0' || i > '1') {
                        throw new Exception("Unexpected character");
                    }
                }
                base.Str = number;
            }

            public static bool operator ==(BitString str1, BitString str2) {
                return str1.Str == str2.Str;
            }

            public static bool operator !=(BitString str1, BitString str2) {
                return str1.Str != str2.Str;
            }

            private int fromBinToDec() {
                char[] numStr = base.Str.ToCharArray();
                Array.Reverse(numStr);
                int rez = 0;
                for (int i = 0; i < numStr.Length; i++) {
                    rez += (numStr[i] - '0') * (int)Math.Pow(2, i);
                }
                return rez;
            }

            public static BitString operator +(BitString num1, BitString num2) {
                return new BitString(Convert.ToString(num1.fromBinToDec() + num2.fromBinToDec(), 2));
            }

            ~BitString() {
                // some logic
            }

            public void Invert() {
                char[] str = new char[base.Length + 1];
                for(int i = 0; i < base.Length; i++) {
                    str[i + 1] = (base.Str[i] == '1') ? '0' : '1';
                }
                str[0] = '1';
                base.Str = new string(str);
                Console.WriteLine(base.Str);
                base.Str = (this + new BitString("1")).Str;
            }

        }


        static void Main(string[] args) {
            BitString num1 = new BitString("1110"),
                num2 = new BitString("11");
            Console.WriteLine((num1 + num2).Str);
            num1.Invert();
            Console.WriteLine(num1.Str);
        }                                      
    }                                          
}
