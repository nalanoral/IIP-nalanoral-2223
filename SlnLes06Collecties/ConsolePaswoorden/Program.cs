using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaswoorden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabelen
            List<string> paswoordOk = new List<string>();
            List<string> paswoordNietOk = new List<string>();

            string[] paswoorden = new string[7];
            paswoorden[0] = "klepketoe";
            paswoorden[1] = "test";
            paswoorden[2] = "Azerty123";
            paswoorden[3] = "rogier@work";
            paswoorden[4] = "password";
            paswoorden[5] = "MisterNasty12";
            paswoorden[6] = "pwnz0red";

            Console.WriteLine("Alle paswoorden: ");

            // inlezen

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(paswoorden[i]);
                Console.ReadLine();

                if (paswoorden[i].Contains("@"))
                {
                    paswoordNietOk.Add(paswoorden[i]);
                }
                else if (paswoorden[i].Contains("password"))
                {
                    paswoordNietOk.Add(paswoorden[i]);
                }
                else if (paswoorden[i].Length <= 8)
                {
                    paswoordNietOk.Add(paswoorden[i]);
                }

                else
                {
                    paswoordOk.Add(paswoorden[i]);

                }
            }

            Console.WriteLine("Ok:" + string.Join(", ", paswoordOk));
            Console.WriteLine("Niet Ok:" + string.Join(", ", paswoordNietOk));
        }

    }
}
