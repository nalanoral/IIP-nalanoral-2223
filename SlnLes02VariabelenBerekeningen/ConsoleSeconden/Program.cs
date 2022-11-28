using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeconden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vraag het aantal seconden
            Console.Write("Geeft het aantal seconden :");

            // lees de seconden en zet het in getal
            string totaalSeconden = Console.ReadLine();
            int totaal = Convert.ToInt32(totaalSeconden);

            // dag,uur, minuten, seconden berekenen
            // 60*60*24 = 86400 (dag)
            // 60 * 60 = 3600 (uur )

            int dag = totaal / 86400;
            int rest = totaal % 86400;
            int uur = rest / 3600;
            int restUren = rest % 3600;
            int minuten = restUren / 60;
            int restMinuten = restUren % 60;
            int seconden = restMinuten / 1;

            // antwoord
            Console.WriteLine($"Dit zijn {dag} dag {uur} uur {minuten} minuten {seconden} seconden", dag, uur, minuten, seconden);
            Console.ReadLine();
        }
    }
}
