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
            // Het getal dat moet geraad worden
            int getal = 5;
            Console.Write("Raad een getal tussen 1 en 10:");

            // De gok van de user
            int raad = Convert.ToInt32(Console.ReadLine());

            // Als de gok groter is dan het getal
            if (raad > getal)
            {
                Console.WriteLine("De gok was te hoog");
            }

            // Als de gok kleiner is dan het getal
            else if (raad < getal)
            {
                Console.WriteLine("De gok was te laag");
            }

            // Anders van de twee vorige(dus als de gok gelijk is aan het getal)
            else
            {
                Console.WriteLine("Je hebt het juiste getal geraden !");
            }
            Console.ReadKey();
        }
    }
}
