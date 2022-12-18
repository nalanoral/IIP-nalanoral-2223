using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels__2_
{
    internal class Program
    {
        private static int VraagPositiefGetal()
        {
            // getal opvragen
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal < 0)
            {
                Console.WriteLine("Het getal moet positief zijn. Geef een getal ");
            }
            else
            {
                Console.Write("");
            }
            return getal;
        }
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
            // returning naar de main
            return tafel;
        }

        static void Main(string[] args)
        {

            int basisGetal = VraagPositiefGetal();
            int lengte = VraagPositiefGetal();

            // maaltafel laten genereren
            string tafel = DrukTafel(basisGetal, lengte);
            // tafel weergeven in de console
            Console.WriteLine(tafel);
            Console.ReadLine();
        }
    }
}
