using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            double height;
            double weight;

            Console.WriteLine("Nhập chiều cao của bạn (m): ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng của bạn (kg): ");
            weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height,2);
            
            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: " + bmi);

            if (bmi < 18.5)
                Console.WriteLine(" Underweight");
            else if (bmi < 25.0)
                Console.WriteLine(" Normal");
            else if (bmi < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");

            Console.ReadKey();
        }
    }
}
