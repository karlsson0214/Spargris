using System;

namespace DemoSpargris
{
    class Spargris
    {
        // objektvariabler
        private string ägare;
        private int belopp;

        // konstruktor
        public Spargris(string namn)
        {
            ägare = namn;
        }
        
        
        // bytt två metoder mot properties
        public string Ägare
        {
            get 
            {
                return ägare;
            }
            private set
            {
                ägare = value;
            }
        }
        public int Belopp
        {
            get
            {
                return belopp;
            }
            private set
            {
                belopp = value;
            }
        }
        // metoder
        public void SättIn(int insättning)
        {
            if (insättning > 0)
            {
                belopp = belopp + insättning;
            }
        }
    }
}