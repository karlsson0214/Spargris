using System;

namespace DemoSpargris
{
    class Spargris
    {
        // objektvariabler - nytt privata
        private string ägare;
        private int belopp;

        // konstruktor
        public Spargris(string namn)
        {
            ägare = namn;
        }
        
        // metoder - nya
        public string GetÄgare()
        {
            return ägare;
        }
        public int GetBelopp()
        {
            return belopp;
        }
        public void SättIn(int insättning)
        {
            if (insättning > 0)
            {
                belopp = belopp + insättning;
            }
        }
    }
}