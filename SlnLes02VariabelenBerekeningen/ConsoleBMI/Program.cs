using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Head

            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");

            // lengte
            Console.WriteLine("Lengte (in cm): ");

            // string omzetten in een double
            double lengte;
            lengte = Convert.ToInt32(Console.ReadLine());

            // gewicht opvragen
            Console.Write("Gewicht (in kg): ");

            double gewicht;
            gewicht = Convert.ToInt32(Console.ReadLine());

           // bmi berekenen en afronden op 1 cijfer na de komma
            double bmi = gewicht / (lengte / 100 * lengte / 100);

            Console.WriteLine("Je BMI bedraagt " + Math.Round(bmi, 1));
            Console.ReadKey();

        }
    }
}
