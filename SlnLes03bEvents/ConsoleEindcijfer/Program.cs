using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            double eindcijfer;
            double dagelijkswerk, project, examen;

            Console.WriteLine("Brekening eindcijfer");
            Console.WriteLine("=======================");

            Console.WriteLine("Geef het cijfer dagelijks werk (op 20): ");
            dagelijkswerk = Convert.ToDouble(Console.ReadLine());
            dagelijkswerk = (dagelijkswerk / 2) * 3; // berekening 30%

            Console.WriteLine("Geef het cijfer op het project (op 20): "); // berekening 20%
            project = Convert.ToDouble(Console.ReadLine());
            project = (project / 2) * 2;

            Console.WriteLine("Geef het cijfer op het examen (op 20): ");
            examen= Convert.ToDouble(Console.ReadLine());
            examen = (examen / 2) * 5; //50%

            eindcijfer = dagelijkswerk + project + examen;

            Console.WriteLine(eindcijfer);
            Console.WriteLine("Je eindcijfer is " + eindcijfer + " %");

            if (eindcijfer < 50)
            {
                Console.WriteLine("-> Onvoldoende");
            }
            else if (eindcijfer >= 50 && eindcijfer < 67.5)
            {
                Console.WriteLine("-> Voldoende");
            }
            else if (eindcijfer >= 67.5 && eindcijfer < 75)
            {
                Console.WriteLine("-> Onderschijding");
            }
            else if (eindcijfer > 75 && eindcijfer < 82.5)
            {
                Console.WriteLine("-> Grote onderschijding");
            }
            else if (eindcijfer > 82.5)
            {
                Console.WriteLine("-> Grootste onderschijding");
            }

            Console.ReadLine();



        }
    }
}
