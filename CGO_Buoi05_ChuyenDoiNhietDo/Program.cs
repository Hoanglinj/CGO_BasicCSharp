using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_ChuyenDoiNhietDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter fahrenheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));
                        break;
                    case 2:
                        Console.WriteLine("Enter Celsius: ");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius));
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
<<<<<<< HEAD
            } while (choice != 0);
=======
            } 
            while (choice != 0);
>>>>>>> b94af0c2fd6445c6297bf61fff1e59e5a02e9e37
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }
    }
}

<<<<<<< HEAD
=======

>>>>>>> b94af0c2fd6445c6297bf61fff1e59e5a02e9e37
