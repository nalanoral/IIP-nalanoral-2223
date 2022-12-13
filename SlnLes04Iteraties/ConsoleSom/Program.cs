using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabelen 
            string getal;
            int som = 0;

            do
            {
                Console.Write("Voer een getal in (q om te stoppen) ");
                getal = Console.ReadLine();
                if (getal != "q")
                {
                    int getalPlus = Convert.ToInt32(getal);
                    som += getalPlus;
                }

                // als de input "q" is geef de som weer
                else
                {
                    Console.WriteLine($"De som is: {som}");
                }
            }
            while (getal != "q");
            Console.ReadKey();
        }
    }
}

