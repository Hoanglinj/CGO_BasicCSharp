using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;

            Console.Write("\n");
            Console.Write("Ve tam giac sao can trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
