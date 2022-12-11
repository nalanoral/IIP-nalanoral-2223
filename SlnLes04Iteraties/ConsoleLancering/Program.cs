using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden tot lancering? ");
            int aantaalseconden = Convert.ToInt32(Console.ReadLine());
            for (int seconden = aantaalseconden; seconden > 0; seconden--)
            {
                Console.WriteLine(seconden);
            }
            Console.WriteLine("Lift Off !");
            Console.ReadLine(); 
        }
    }
}
