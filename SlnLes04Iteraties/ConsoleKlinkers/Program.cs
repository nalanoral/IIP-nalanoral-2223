using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");

            // variabelen
            string tekst = Console.ReadLine();
            int aantaalKlinkers = 0;
            int aantaalMedeklinkers = 0;
            int aantaalWords = 0;

            foreach (char c in tekst)
            {
                // zet om naar numerieke waarde
                char a = Convert.ToChar(c);

                // eentje bij
                a++;

                if (c == ' ')
                    aantaalWords++;
                else if (c == 'a')
                    aantaalKlinkers++;
                else if (c == 'e')
                    aantaalKlinkers++;
                else if (c == 'o')
                    aantaalKlinkers++;
                else if (c == 'u')
                    aantaalKlinkers++;
                else if (c == 'i')
                    aantaalKlinkers++;
                else aantaalMedeklinkers++;
            }
            Console.WriteLine();
            Console.WriteLine($"deze tekst bevat {aantaalKlinkers} klinkers");
            Console.WriteLine($"deze tekst bevat {aantaalMedeklinkers} medeklinkers");
            Console.WriteLine($"deze tekst bevat {aantaalWords} woorden");
            Console.Write("in geheimschrift: ");

            foreach (char letter in tekst)
            {
                // Volgende karakter van de Ascci tabel
                Console.Write((char)Convert.ToChar(letter + 1));
            }

            Console.ReadKey();
        }
    }
}