using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    internal class Program
    {
        private static int VraagPositiefGetal()
        {
            // getal opvragen
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            while (getal <= 0) 
            {
                Console.Write("Het getal moet positief zijn. Geef een getal ");
                getal = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine(tafel);

            
            Console.ReadLine();
        }
    }
}
