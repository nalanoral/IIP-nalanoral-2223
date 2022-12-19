using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFaculteit
{
    internal class Program
    {

        private static int VraagGetal()
        {
            // vraag een getal
            Console.WriteLine(" Geef een geheel getal");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;
        }
        private static int Facultetit(int n)
        {
            // variabelen
            int facultetit = n;

            // fac. berekenen
            for (int i = 1; i < n; i++)
            {
                int newGetal = n - i;
                facultetit *= newGetal;
            }

            return facultetit;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("FACULTEIT BEREKENEN");
            int getal = VraagGetal();

            int faculteitResult = Facultetit(getal);

            Console.WriteLine($" De facultetit is : {faculteitResult}");
            Console.ReadKey();
        }
    }
}