using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            double totalfooi;  
            double wisselgeld;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WELKOM IN HET BUFFETRESTAURANT");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Alles is à volonté en dranken zijn inbegrepen !");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("!!Promotie !! Vandaag ronden we het totaalbegrag af naar beneden");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Aantal seizoensbuffets ( €18.5):");
            int aantaalseizoensbuffets;
            aantaalseizoensbuffets = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Aantal dessertenbuffets (€7.95)");
            int aantaaldessertenbuffets;
            aantaaldessertenbuffets = Convert.ToInt32(Console.ReadLine());   

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Aantal kidsmenu (€8.95)");
            int aantaalkidsmenu;
            aantaalkidsmenu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fooi ");

            totalfooi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total te betalen : ");
            double totalBedraagt = (SEIZOENSBUFFETS * aantaalseizoensbuffets) + (DESSERTBUFFETS * aantaaldessertenbuffets) + (KIDSMENU * aantaalkidsmenu) + (totalfooi * Fooi);
            Console.WriteLine("total :" + Math.Round(totalBedraagt, 2));
            Console.ReadKey();
        }
    }
}
