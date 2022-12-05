using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestelling
{
    internal class Program
    {
        const int PRIJSMARGHERITA = 8;
        const int PRIJSFUNGI = 10;
        const int PRIJSDIABOLO = 11;
        const int PRIJSBEZORGING = 3;

        static void Main(string[] args)
        {
            string pizzaKeuze = "";
            string pizzaGrootekeuze = "";
            

            double totaal = 0;
            Console.WriteLine(@"PIZZA BESTELLING
================
Kies je pizza: 
a) Margherita 8 euro
b) Funghi 10 euro
c) Diabolo 11 euro
>>> Wat is je keuze? ");
            // keuze pizza inlezen
            char pizza = Convert.ToChar(Console.ReadLine());

            // keuze grootte inlezen
            Console.WriteLine(@" Kies de grootte
a) 15 cm (klein; - 20%)
b) 20 cm (normaal)
c) 25 cm (groot; + 20%)
>>> Wat is je keuze? ");

            char grootte = Convert.ToChar(Console.ReadLine());

            // keuze  bezorging
            Console.WriteLine(" thuis bezorgen (3 euro extra)? ja /nee ");
            string bezorgingsKeuze = Console.ReadLine();

           
            switch (pizza) 
            {
                case 'a': pizzaKeuze = "Margherita"; totaal += PRIJSMARGHERITA; break;
                case 'b': pizzaKeuze = "Fungi"; totaal += PRIJSFUNGI; break;
                case 'c': pizzaKeuze = "Diabolo"; totaal += PRIJSDIABOLO; break;
                default: break;
            }

            switch (grootte)
            {
                case 'a': pizzaGrootekeuze = "klein"; totaal *= 0.8; break;
                case 'b': pizzaGrootekeuze = "Normaal"; totaal *= 1; break;
                case 'c': pizzaGrootekeuze = "Groot"; totaal *= 1.2; break;
                default: break;
            }

            switch (bezorgingsKeuze)
            {
                case "ja": bezorgingsKeuze = "thuis bezorging"; totaal += PRIJSBEZORGING; break;
                case "nee": bezorgingsKeuze = "afhalen"; break;
                default: break;
            }

            Console.WriteLine($"Jouw bestelling: {pizzaGrootekeuze} pizza {pizzaKeuze} voor {totaal}euro {bezorgingsKeuze}");
             // uitvoeren ? //

        }
    }
}