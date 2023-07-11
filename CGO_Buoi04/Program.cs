using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Nhap slpt: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
               Console.Write("Gia tri thu {0}= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int tong = 0;
            foreach (int item in a)
            {
                tong += item;
                Console.Write(item + " ");
            }
            Console.WriteLine("\nTong cac so la " + tong);

            Console.ReadKey();
        }

    }
}
