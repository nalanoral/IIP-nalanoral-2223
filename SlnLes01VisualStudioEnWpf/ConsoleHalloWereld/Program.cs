using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHalloWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wereld!");
            Console.Write("Hoe heet je? ");
            string name = Console.ReadLine();
            Console.Write("Aangename kennismaking, ");
            Console.WriteLine(name);
            Console.WriteLine("druk een toestom verder te gaan...");
            Console.ReadKey();
        }
    }
}
