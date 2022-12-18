using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels__1_
{
    internal class Program
    {
        private static string DrukTafel(int getal, int lengte)
        {
            // maaltafel genereren
            string tafel = "";
            for (int i = 1; i <= lengte; i++)
            {
                int vermenigvuldiging = getal * i;
                tafel += $"{getal} x {i} = {vermenigvuldiging}";
                tafel += Environment.NewLine;
            }
            return tafel;
        }
        static void Main(string[] args)
        {
            // getal opvragen
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef een getal: ");
            int lengte = Convert.ToInt32(Console.ReadLine());
            string maaltafel = DrukTafel(getal, lengte);

            Console.WriteLine(value: $" {maaltafel}");

            Console.ReadKey();
        }
    }
    
}
