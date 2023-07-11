using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi03_KtSoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap vao so dong cua hinh chu nhat: ");
            int rowschunhat = Convert.ToInt32(Console.ReadLine());
            //sử dụng vòng lặp for thứ nhất để lặp qua các dòng
            for (int i = 1; i <= rowschunhat; i++)
            {
                //sử dụng vòng lặp for thứ hai để in ký tự * cho mỗi dòng
                for (int j = 1; j <= i; j+=2)
                {
                    Console.Write("*");
                }
                //sau khi in mỗi dòng sẽ xuống hàng
                Console.Write("\n");

            }
            Console.ReadKey();
        }
    }
}
