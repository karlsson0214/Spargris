using System;

namespace DemoSpargris
{
    class Program
    {
        static void Main(string[] args)
        {
            // önskemål
            // grisen kan inte byta ägare
            // grisen måste ha en ägare
            // går att sätta in pengar 
            // går att tömma grisen
            // går inte att ta ut lite av innehållet

            Spargris adasGris = new Spargris("Ada");

            // sätt in pengar
            adasGris.belopp = 10;
            adasGris.Print();
            // Ägare: Ada
            // innehåller 10 kr
            // men vill att det måste finnas en ägare
            // Löst - nu finns ägare

            // adasGris.ägare = "Ada";

            // sätt in mer pengar
            adasGris.belopp = adasGris.belopp + 30;  // lite bökigt
            adasGris.Print();
            // Ägare: Ada
            // innehåll: 40 kr

            // sätt in mer pengar
            adasGris.belopp = 5;
            adasGris.Print();
            // Ägare: Ada
            // innehåll: 5 kr
            // Oj, nu försvann 40 kr

            // sätt in mer pengar
            adasGris.belopp = -2;
            adasGris.Print();
            // Ägare: Ada
            // innehåll: 3 kr
            // Oj, kan ta ut pengar

            // sätt in mer pengar
            adasGris.belopp = -100;
            adasGris.Print();
            // Ägare: Ada
            // innehåll: -98 kr
            // Oj, kan ta ut mer än det finns





        }
    }
}
