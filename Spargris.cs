using System;

namespace DemoSpargris
{
    class Spargris
    {
        public string ägare;
        public int belopp;

        public void Print()
        {
            Console.WriteLine("Ägare: " + ägare);
            Console.WriteLine("innehåll: " + belopp + " kr");
        }

    }
}