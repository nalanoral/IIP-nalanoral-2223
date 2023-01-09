using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScores
{
    internal class Program
    {
        private static object positieKleinste;

        static void Main(string[] args)
        {
            string scheiding = ", ";
            string laatste = " en ";

            int[] scores = new int[10];
            Random rnd = new Random();

            int gemiddelde = BepaalGemiddelde(scores);
            int grootste = ZoekGrootste(scores);
            int kleinste = ZoekKleinste(scores);

            // array vullen met random scores
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = rnd.Next(0, 20);
            }
            Console.Write("Scores test: ");
            PrintScores(scores, scheiding, laatste);
            Console.WriteLine();
            
            Console.WriteLine($"De gemiddelde score van de test was: {gemiddelde}");
            Console.WriteLine($"De slechte score op de test was: {kleinste} (positie {positieKleinste}) ");
            Console.WriteLine($"De beste score op de test was: {grootste} (positie {positieKleinste}) ");
            Console.ReadLine();

        }

        private static void PrintScores(int[] scores, string scheiding, string laatste)
        {
            string puntenlijst = "";
            for (int i = 0; i < scores.Length - 1; i++)
            {
                puntenlijst += scores[i] + scheiding;
            }
            Console.WriteLine($"{puntenlijst} {laatste} {scores[6]}");
        }

        private static int ZoekKleinste(int[] scores)
        {
            int kleinste = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < kleinste)
                    kleinste = scores[i];
                int positieKleinste = scores[i] + 1;

            }
            return kleinste;
        }

        private static int ZoekGrootste(int[] scores)
        {
            int grootste = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > grootste)
                    grootste = scores[i];
                int positieGrootese = scores[i] + 1;
            }
            return grootste;
        }

        private static int BepaalGemiddelde(int[] scores)
        {
            int gemiddelde = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                gemiddelde += scores[i];

            }
            gemiddelde = gemiddelde / scores.Length;
            return gemiddelde;
        }

    }
}
