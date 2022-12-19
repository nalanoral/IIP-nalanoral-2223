using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTemperatuur
{
    internal class Program
    {
        private static double CelsiustoFahrenheit(double grad)
        {
            double change = grad * 1.8 + 32;
            return change;
        }
        private static double FahrenheittoCelsius(double grad)
        {
            double change = (grad - 32) / 1.8;
            return change;
        }

        private static double CelsiustoKelvin(double grad)
        {
            double change = grad + 273.15;
            return change;
        }

        private static double KelvintoCelsius(double grad)
        {
            double change = grad - 273.15;
            return change;
        }
        static void Main(string[] args)
        {
            //variablen
            double change;
            double grad;
            string chooise;

            Console.WriteLine("TEMPERATUUR CONVERSIE");
            Console.WriteLine("======================");

            Console.WriteLine(@"
a. Celsius naar Faherenheit
b.Fahrenheit naar Celsius
c.Celsius naar Kelvin
d.Kelvin naar Celcius
x.Afsluiten" + Environment.NewLine);
            do
            {
                Console.WriteLine("maak je keuze");
                chooise = Console.ReadLine();

                // using methodes
                if (chooise == "a")
                {
                    Console.Write("Celsius:");
                    grad = Convert.ToDouble(Console.ReadLine());
                    change = CelsiustoFahrenheit(grad);
                    Console.WriteLine($" => naar Fahrenheit :{change} °F ");
                }
                else if (chooise == "b")
                {
                    Console.Write("Kelvin:");
                    grad = Convert.ToDouble(Console.ReadLine());
                    change = FahrenheittoCelsius(grad);
                    Console.WriteLine($" => naar Celsius :{change} °C");
                }
                else if (chooise == "c")
                {
                    Console.Write("Celsius");
                    grad = Convert.ToDouble(Console.ReadLine());
                    change = CelsiustoKelvin(grad);
                    Console.WriteLine($" => naar Kelvin :{change} °K");
                }
                else if (chooise == "d")
                {
                    Console.Write("Kelvin:");
                    grad = Convert.ToDouble(Console.ReadLine());
                    change = KelvintoCelsius(grad);
                    Console.WriteLine($" => naar Celsius :{change} °C");
                }
            }
            while (chooise != "x");
        }
    }
}
