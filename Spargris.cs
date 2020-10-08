using System;

namespace DemoSpargris
{
    class Spargris
    {
        // objektvariabler
        public string ägare;
        public int belopp;

        // metoder
        public void Print()
        {
            Console.WriteLine("Ägare: " + ägare);
            Console.WriteLine("innehåll: " + belopp + " kr");
        }

    }
}