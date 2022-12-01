using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SEIZOENSBUFFETS = 18.5;
            const double DESSERTBUFFETS = 7.95;
            const double KIDSMENU = 8.98;
            const double Fooi = 4.5;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"WELKOM IN HET BUFFETRESTAURANT
===============================
Alles is à volonté en dranken zijn inbegrepen !
!!Promotie !! Vandaag ronden we het totaalbegrag af naar beneden ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Aantal seizoensbuffets (€{SEIZOENSBUFFETS}):");
            int aantaalseizoensbuffets;
            aantaalseizoensbuffets = Convert.ToInt32(Console.ReadLine());
  
            Console.WriteLine($"Aantal dessertenbuffets (€{DESSERTBUFFETS}):");
            int aantaaldessertenbuffets;
            aantaaldessertenbuffets = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine($"Aantal kidsmenu (€{KIDSMENU}):");
            int aantaalkidsmenu;
            aantaalkidsmenu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Fooi ( 0 indien geen):");
            double fooiValue = Convert.ToDouble(Console.ReadLine());    

            double totalfooi = Math.Floor(fooiValue);

            Console.WriteLine("Total te betalen : ");
            
            double totalBedraagt = (SEIZOENSBUFFETS * aantaalseizoensbuffets) + (DESSERTBUFFETS * aantaaldessertenbuffets) + (KIDSMENU * aantaalkidsmenu) + (totalfooi * Fooi);
            
            Console.WriteLine($"Afgerond naar beneden : €{Math.Floor(totalBedraagt)}");
            Console.WriteLine();

            Console.Write("Cash Betald :");
            int cash = Convert.ToInt32(Console.ReadLine());
            cash -= Convert.ToInt32(Math.Floor(totalBedraagt));

            int euro50 = cash / 50;
            int euro20 = (cash % 50) / 20;
            int euro10 = (cash % 20) / 10;
            int euro5 = (cash % 10) / 5;
            int euro2 = (cash % 5) / 2;
            int euro1 = cash % 2;
            Console.WriteLine($@" u krijgt terug :
-{euro50} briefje(s) van 50
-{euro20} briefje(s) van 20
-{euro10} briefje(s) van 10
-{euro5} briefje(s) van 5
-{euro2} briefje(s) van 2
-{euro1} briefje(s) van 1
");
            Console.ReadKey();
        }
    }
}
