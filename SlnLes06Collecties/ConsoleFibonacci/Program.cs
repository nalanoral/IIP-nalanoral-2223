using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibonacci
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hoveel Fibonacci getallen wil je afdrukken:");
            int aantalFibonacci = Convert.ToInt32(Console.ReadLine());

            // via website =>> https://dotnetfiddle.net/dWZck8 //
            int[] fibonacci = new int[15];
            fibonacci[0] = 1;
            fibonacci[1] = 1;


            Console.WriteLine(" Eerste 15 fibonaaci getallen: " + fibonacci[0] + " " + fibonacci[1] + " " );

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                Console.Write($" {fibonacci[i]}");
            }
            Console.ReadKey();

        }
    }
}
