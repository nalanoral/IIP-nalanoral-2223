using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAsciiArt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string art;

            Console.WriteLine(@"
               ##          ##
                 ##      ##
               ##############
            ####  ######  ####
            #####################
            ##  #############  ##
            ##  ##         ##  ##
                  ###  ###
           
           ");
            art= Console.ReadLine();
           Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
