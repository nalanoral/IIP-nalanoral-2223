using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // te raden getal
            Random rnd = new Random();
            int getal = rnd.Next(1, 10);

            Console.WriteLine("Raad een getal tussen 1 en 10");

            // vraag een gok zolang het niet het geheim getal is
            int aantalPogingen = 0;
            int poging;
            do
            {
                aantalPogingen++;
                Console.Write($"Poging {aantalPogingen}: ");
                poging = Convert.ToInt32(Console.ReadLine());

                if (aantalPogingen > 3 && getal == poging)
                {
                    Console.WriteLine("Geraden!");
                }
                else
#pragma warning disable SA1520 // Use braces consistently
                    Console.WriteLine("Volgende keer beter");
                Console.Read();

            } while (getal != poging);
            Console.ReadLine();
        }
    }
}

