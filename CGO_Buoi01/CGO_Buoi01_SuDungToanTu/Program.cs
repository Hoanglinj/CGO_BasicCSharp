using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi01_SuDungToanTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
            Console.ReadKey();
        }
    }
}
