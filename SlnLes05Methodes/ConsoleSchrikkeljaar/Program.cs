using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSchrikkeljaar
{
    internal class Program
    {
        static string Schrikkeljaar(int jaartal)
        {
            string answer = "";

            // controleren het een Schrikkeljaar is of niet 
            if (jaartal % 100 == 0 || jaartal % 400 == 0 || jaartal % 4 == 0)
            {
                answer += "een Schrikkeljaar";
            }
            else
            {
                answer += "geen Schrikkeljaar";
            }

            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("SCHRIKKELJAAR");
            Console.WriteLine("==============");

            int jaartal;
            do
            {
                Console.Write("Geef een jaartal :");
                jaartal = Convert.ToInt32(Console.ReadLine());
                string answer = Schrikkeljaar(jaartal);
                Console.WriteLine($" Het jaar {jaartal} is {answer} ");
            }
            while (jaartal > 0);

            Console.WriteLine("Bedankt en tot ziens.");
            Console.ReadKey();
        }
    }
}
