using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCsv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] namen = new string[] { "Nalan", "Saleha", "Indra", "Ralph", "Marie" };
            string[] games = new string[] { "schaak", "dammen", "backgammon" };
            string[] score = new string[] { "1-2", "2-1", "3-0", "3-2", "3-3" };

            for (int i = 0; i <= 100; i++)
            {
                // random speler en spel kiezen
                int Speler1 = random.Next(0, namen.Length);
                int Speler2 = random.Next(0, namen.Length);
                int spelchooise = random.Next(0, games.Length);
                int scores = random.Next(0, score.Length);

                string spelerName = namen[Speler1];
                string spelerName2 = namen[Speler2];
                string spel = games[spelchooise];

                string csvContent = "";

                csvContent = $"{i + 1};{spelerName};{spelerName2};{spel};{scores}";
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = System.IO.Path.Combine(folderPath, "wedstrijden.csv");

                using (StreamWriter writer = File.CreateText(filePath))
                {

                    writer.WriteLine(csvContent);
                }
                Console.WriteLine("tis ok");
                Console.ReadKey();
            }
        }

    }
}

