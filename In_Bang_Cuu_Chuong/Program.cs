using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Bang_Cuu_Chuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            for(int i = 2; i <= 10; i++)
            {
                Console.WriteLine("Bảng cửu chương: " + i);
               
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.WriteLine("{0} x {1} = {2}", i, j, (result));
                }
                
            }
            Console.ReadKey();

        }
    }
}
