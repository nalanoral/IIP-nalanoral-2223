using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WELKOME OP DE LOTTOTREKKING");
            Console.WriteLine("===========================");


            // Ingeven van de lotto getallen
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Geef 6 getallen tussen 1 en 42 gescheiden door spaties :");
            Console.ReadLine();

            int[] trekking = { 4, 8, 17, 22, 31, 39, 41 };
            Array.Sort(trekking);

            int i;
            for (i = 0; i < trekking.Length; i++)
            {


                // Console.WriteLine($"Trekking : ");//
                Console.Write(trekking[i]);

            }

            List<int> juiste = new List<int>();

            int[] lottoFormulier = new int[6];

            for (i = 0; i < lottoFormulier.Length; i++)
            {
                Console.Write($" ++++++ {i + 1}: ");
               

                lottoFormulier[i] = Convert.ToInt32(Console.ReadLine());
                if (lottoFormulier[i] == trekking[0] ||
                    lottoFormulier[i] == trekking[1] ||
                    lottoFormulier[i] == trekking[2] ||
                    lottoFormulier[i] == trekking[3] ||
                    lottoFormulier[i] == trekking[4] ||
                    lottoFormulier[i] == trekking[5] ||
                    lottoFormulier[i] == trekking[6])
                {
                    juiste.Add(lottoFormulier[i]);
                }
            }
            Console.WriteLine(juiste.Count);
            Console.WriteLine("Je hebt " + juiste.Count + String.Join(" - ", juiste));

        }
    }
}
