using System;

namespace eventsAndDelegates {
    class Test {
        public event Action something = delegate { };

        public void Raise() {
            something();
        }
    }
    class Program {
        static void Main(string[] args) {
            Test el = new Test();
            el.something += () => Console.WriteLine("hello");
            el.Raise();
            el.Raise();
        }
    }
}
