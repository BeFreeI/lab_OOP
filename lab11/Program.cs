using System;
using System.Collections.Generic;

namespace lab11 {

    struct AEROFLOT : IComparable<AEROFLOT> {
        public string nameAim,
            typeOfPlain;
        public int nRace;

        public AEROFLOT(string aim, string type, int num) {
            this.nameAim = aim;
            this.typeOfPlain = type;
            this.nRace = num;
        }

        public void set(string aim, string type, int num) {
            this.nameAim = aim;
            this.typeOfPlain = type;
            this.nRace = num;
        }

        public int CompareTo(AEROFLOT p2) {
            return this.nameAim.CompareTo(p2.nameAim);
        }

        public static bool operator ==(AEROFLOT r1, AEROFLOT r2) {
            return r1.typeOfPlain == r2.typeOfPlain;
        }

        public static bool operator !=(AEROFLOT r1, AEROFLOT r2) {
            return r1.typeOfPlain != r2.typeOfPlain;
        }

        public static bool operator >(AEROFLOT r1, AEROFLOT r2) {
            return r1.nRace > r2.nRace;
        }

        public static bool operator <(AEROFLOT r1, AEROFLOT r2) {
            return r1.nRace < r2.nRace;
        }

        public static bool operator >=(AEROFLOT r1, AEROFLOT r2) {
            return r1.nRace >= r2.nRace;
        }

        public static bool operator <=(AEROFLOT r1, AEROFLOT r2) {
            return r1.nRace <= r2.nRace;
        }

    }

    class Program {
        static void Main(string[] args) {
            List<AEROFLOT> arr = new List<AEROFLOT>();
            arr.Add(new AEROFLOT("Brest", "pass", 1));
            arr.Add(new AEROFLOT("Astana", "pass", 2));
            arr.Sort();
            for(int i = 0; i < arr.Count; i++) {
                Console.WriteLine($"{arr[i].nameAim} {arr[i].nRace} {arr[i].typeOfPlain}");
            }
        }
    }
}
