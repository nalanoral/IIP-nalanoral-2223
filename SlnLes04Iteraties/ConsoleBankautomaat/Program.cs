using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totaalBedrag = 500;
            string keuze;
            int pincode = 0;
            Console.WriteLine("Bankautomaat");
            Console.WriteLine("============");
            Console.WriteLine();

            Console.WriteLine("geef je pincode");
            int ingegevenPincode = Convert.ToInt32(Console.ReadLine());

            if (ingegevenPincode == pincode)
            {
                Console.WriteLine("je bent ingelogd");
            }

            do
            {
                Console.WriteLine(@"a. afhaling
b. storting
c. stoppen");
                Console.Write("je keuze: ");
                keuze = Console.ReadLine();
                Console.WriteLine();
                if (keuze == "a")
                {
                    Console.Write("Welk bedrag wil je afhalen: ");
                    int bedrag = Convert.ToInt32(Console.ReadLine());
                    totaalBedrag -= bedrag;
                    Console.WriteLine($"afhaling ok - het nieuwe saldo is {totaalBedrag}");
                    Console.WriteLine();
                }
                else if (keuze == "b")
                {
                    Console.Write("Welk bedrag wil je storten: ");
                    int bedrag = Convert.ToInt32(Console.ReadLine());
                    totaalBedrag += bedrag;
                    Console.WriteLine($"storting ok - het nieuwe saldo is {totaalBedrag}");
                    Console.WriteLine();
                }
                else if (keuze == "c")
                {
                    Console.WriteLine("Bedankt en tot ziens.");
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze");
                }
            }
            while (keuze != "c");
            Console.ReadLine();
        }
    }
}
