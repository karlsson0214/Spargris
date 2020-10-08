using System;

namespace DemoSpargris
{
    class Spargris
    {
        // objektvariabler
        // private istället för public
        private string ägare;
        public int belopp;

        // konstruktor - ny
        public Spargris(string namn)
        {
            ägare = namn;
        }

        // metoder
        public void Print()
        {
            Console.WriteLine("Ägare: " + ägare);
            Console.WriteLine("innehåll: " + belopp + " kr");
        }

    }
}