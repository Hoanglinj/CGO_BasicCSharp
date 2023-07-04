//Ghi chu: using thu vien sai. Neu chu xam thu vien chua sai, chu mau den dang su dung
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**Ghi chu nhieu dong
 * namespace: du an lon lien ket voi nhau qua namespace
 * class: xay dung doi tuong quan ly
 * references, changes (do connect voi github, xac dinh lenh do ai cap nhat thay doi)
 * Main: ham kich hoat chay dau tien
 */

namespace CGO_Buoi01
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Mời bạn nhập tên: ");
            string sHoTen = Console.ReadLine();
            Console.WriteLine("Xin chào " + sHoTen);
            Console.ReadKey();
        }
    }
}
