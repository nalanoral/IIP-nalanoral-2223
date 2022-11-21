using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGreenHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WELKOME BIJ GREENHOUSE REASTAURANT***");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Kies een grootte (kleine of grote): ");
            string grootte = Console.ReadLine();
            Console.WriteLine("Kies een basis (quinoa, rijst of salade): ");
            string basis = Console.ReadLine();
            Console.WriteLine("Kies een soort (vegan, zalm of kip): ");
            string soort = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("je bestelling is : een" + " " + " " + grootte + " " +  basis + " met "+ soort);
            Console.ReadKey();



        }
    }
}
