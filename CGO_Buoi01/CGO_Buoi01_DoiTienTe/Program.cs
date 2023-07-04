using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi01_DoiTienTe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            const int tigia = 23000;
            Console.Write("Mời bạn nhập số USD: ");
            string input = Console.ReadLine();  //dữ liệu nhập từ bàn phím là chuỗi
            int dola = int.Parse(input);  //chuyển chuỗi thành số nguyên
            Console.WriteLine("Số tiền VND của bạn là " + dola*tigia);
            Console.ReadKey();
        }
    }
}
