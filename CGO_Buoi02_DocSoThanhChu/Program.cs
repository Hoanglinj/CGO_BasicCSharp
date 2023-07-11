using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi02_DocSoThanhChu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số cần đọc: ");
            string input = Console.ReadLine();
            int sonhap = int.Parse(input);
            int donvi = sonhap % 10;            
            int hangchuc = (sonhap / 10) % 10;  
            int hangtram = sonhap % 100;

            if (input.Length == 3)
            {
                switch (hangtram)
                {
                    case 1: Console.Write("Một trăm "); break;
                    case 2: Console.Write("Hai trăm "); break;
                    case 3: Console.Write("Ba trăm "); break;
                    case 4: Console.Write("Bốn trăm "); break;
                    case 5: Console.Write("Năm trăm "); break;
                    case 6: Console.Write("Sáu trăm "); break;
                    case 7: Console.Write("Bảy trăm "); break;
                    case 8: Console.Write("Tám trăm "); break;
                    case 9: Console.Write("Chín trăm "); break;
                }
                
                if (hangchuc % 10 == 0 && donvi != 0)
                {
                    Console.Write("lẻ ");
                }
                
                switch (hangchuc)
                {
                    case 1: Console.Write("mười "); break;
                    case 2: Console.Write("hai mươi "); break;
                    case 3: Console.Write("ba mươi "); break;
                    case 4: Console.Write("bốn mươi "); break;
                    case 5: Console.Write("năm mươi "); break;
                    case 6: Console.Write("sáu mươi "); break;
                    case 7: Console.Write("bảy mươi "); break;
                    case 8: Console.Write("tám mươi "); break;
                    case 9: Console.Write("chín mươi "); break;
                }
                
                switch (donvi)
                {
                    case 1: Console.Write("một "); break;
                    case 2: Console.Write("hai "); break;
                    case 3: Console.Write("ba "); break;
                    case 4: Console.Write("bốn "); break;
                    case 5: Console.Write("lăm "); break;
                    case 6: Console.Write("sáu "); break;
                    case 7: Console.Write("bảy "); break;
                    case 8: Console.Write("tám "); break;
                    case 9: Console.Write("chín "); break;
                }
            }



            else if (input.Length == 2)
            {
                if (sonhap >= 20 && sonhap < 100)
                {
                    switch (hangchuc)
                    {
                        case 2: Console.Write("Hai"); break;
                        case 3: Console.Write("Ba"); break;
                        case 4: Console.Write("Bốn"); break;
                        case 5: Console.Write("Năm"); break;
                        case 6: Console.Write("Sáu"); break;
                        case 7: Console.Write("Bảy"); break;
                        case 8: Console.Write("Tám"); break;
                        case 9: Console.Write("Chín"); break;
                    }
                    Console.Write(" mươi");
                    switch (donvi)
                    {
                        case 0: Console.Write(""); break;
                        case 1: Console.Write(" mốt"); break;
                        case 2: Console.Write(" hai"); break;
                        case 3: Console.Write(" ba"); break;
                        case 4: Console.Write(" bốn"); break;
                        case 5: Console.Write(" lăm"); break;
                        case 6: Console.Write(" sáu"); break;
                        case 7: Console.Write(" bảy"); break;
                        case 8: Console.Write(" tám"); break;
                        case 9: Console.Write(" chín"); break;
                    }

                }
                else if (sonhap >= 10 && sonhap <= 19)
                {
                    Console.Write("mười");
                    switch (donvi)
                    {
                        case 0: Console.Write(""); break;
                        case 1: Console.Write(" một"); break;
                        case 2: Console.Write(" hai"); break;
                        case 3: Console.Write(" ba"); break;
                        case 4: Console.Write(" bốn"); break;
                        case 5: Console.Write(" lăm"); break;
                        case 6: Console.Write(" sáu"); break;
                        case 7: Console.Write(" bảy"); break;
                        case 8: Console.Write(" tám"); break;
                        case 9: Console.Write(" chín"); break;
                    }
                }
            }
            else if (input.Length == 1)
            {
                switch (donvi)
                {
                    case 0: Console.Write("không"); break;
                    case 1: Console.Write("một"); break;
                    case 2: Console.Write("hai"); break;
                    case 3: Console.Write("ba"); break;
                    case 4: Console.Write("bốn"); break;
                    case 5: Console.Write("năm"); break;
                    case 6: Console.Write("sáu"); break;
                    case 7: Console.Write("bảy"); break;
                    case 8: Console.Write("tám"); break;
                    case 9: Console.Write("chín"); break;

                }
            } 
            Console.ReadKey();
        }
    }
}
