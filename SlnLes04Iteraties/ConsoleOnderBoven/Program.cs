using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnderBoven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // les een grens in
            Console.Write("Geef een ondergrens: ");
            int ondergrens = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef een bovengrens: ");
            int bovengrens = Convert.ToInt32(Console.ReadLine());

            // bovengrens < ondergrens or bovengrens == ondergrens
            while (bovengrens < ondergrens)
            {
                Console.Write("Bovengrens mag niet kleiner zijn dan ondergrens. Geef een bovengrens: ");
                bovengrens = Convert.ToInt32(Console.ReadLine());
            }   

            while (bovengrens == ondergrens)
            {
                Console.Write("Bovengrens mag niet gelijk zijn dan ondergrens. Geef een bovengrens: ");
                bovengrens = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Bereik: van {ondergrens} tot {bovengrens} ");
            Console.Read();

        }
    }
}
