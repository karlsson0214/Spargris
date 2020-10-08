using System;

namespace DemoSpargris
{
    class Test
    {
        // objektvariabler
        private Spargris grisen;

        // konstruktor
        public Test()
        {
            grisen = new Spargris("Ada"); // lagt till "Ada"
        }

        // metoder
        public void Run()
        {
            // önskemål
            // grisen kan inte byta ägare
            // grisen måste ha en ägare
            // går att sätta in pengar 
            // går att tömma grisen
            // går inte att ta ut lite av innehållet

            // sätt in pengar
            grisen.belopp = 10;
            Print();
            // Ägare:
            // innehåller 10 kr
            // men vill att det måste finnas en ägare

            grisen.ägare = "Beda";

            // sätt in mer pengar
            grisen.belopp = grisen.belopp + 30;  // lite bökigt
            Print();
            // Ägare: Beda
            // innehåll: 40 kr
            // Oj, bytte ägare

            // sätt in mer pengar
            grisen.belopp = 5;
            Print();
            // Ägare: Beda
            // innehåll: 5 kr
            // Oj, nu försvann 40 kr

            // sätt in mer pengar
            grisen.belopp = -2;
            Print();
            // Ägare: Beda
            // innehåll: 3 kr
            // Oj, kan ta ut pengar

            // sätt in mer pengar
            grisen.belopp = -100;
            Print();
            // Ägare: Beda
            // innehåll: -98 kr
            // Oj, kan ta ut mer än det finns
        }
        // hjälpmetod för att skriva ut information om en spargris
        private void Print()
        {
            Console.WriteLine("Ägare: " + grisen.ägare);
            Console.WriteLine("innehåll: " + grisen.belopp + " kr");
        }

    }

}