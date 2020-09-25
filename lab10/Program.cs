using System;
using System.Security.Cryptography.X509Certificates;

namespace lab10 {
    struct AEROFLOT : IComparable<AEROFLOT> {
        public string nameAim,
            typeOfPlain;
        public int nRace;
        public void set(string aim, string type, int num) {
            this.nameAim = aim;
            this.typeOfPlain = type;
            this.nRace = num;
        }
        public int CompareTo(AEROFLOT p2) {
            return this.nameAim.CompareTo(p2.nameAim);
        }
    }

    class Program {
        static void Main(string[] args) {
            AEROFLOT[] arr = new AEROFLOT[8];
            for(int i = 0; i < arr.Length - 1; i++) {
                arr[i].set("Brest", "pass", i);
            }
            arr[7].set("Astana", "pass", 7);
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"{arr[i].nameAim} {arr[i].typeOfPlain} {arr[i].nRace}");
            }
        }
    }
}
