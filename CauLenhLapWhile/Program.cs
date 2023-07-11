using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauLenhLapWhile
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a = 15, b = 8;
            Console.Write("UCLN cua " + a + " va " + b + " la ");
            while ( a*b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            int UCLN = a + b;
            Console.Write(UCLN);
            Console.ReadKey();
        }

           
    }
}
