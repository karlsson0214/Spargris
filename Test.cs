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
            grisen.SättIn(10);
            Print();
            // Ägare: Ada
            // innehåller 10 kr

            // ägare är privat så nedanstående går inte längre
            //grisen.ägare = "Beda";

            // sätt in mer pengar
            grisen.SättIn(30);  // lite bökigt, nu smidigt
            Print();
            // Ägare: Ada
            // innehåll: 40 kr

            // sätt in mer pengar
            grisen.SättIn(5);
            Print();
            // Ägare: Ada
            // innehåll: 45 kr
            // ok nu inget försvinner

            // sätt in mer pengar
            grisen.SättIn(-2);
            Print();
            // Ägare: Ada
            // innehåll: 45 kr
            // ok, kan inte ta ut pengar

            // sätt in mer pengar
            grisen.SättIn(-100);
            Print();
            // Ägare: Ada
            // innehåll: 45 kr
            // ok, kan inte ta ut pengar
        }
        // hjälpmetod för att skriva ut information om en spargris
        private void Print()
        {
            Console.WriteLine("Ägare: " + grisen.Ägare);
            Console.WriteLine("innehåll: " + grisen.Belopp + " kr");
        }

    }

}