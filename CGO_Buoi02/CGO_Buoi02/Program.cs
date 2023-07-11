using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ngay sinh cua ban: ");
            string input = Console.ReadLine();

            DateTime dob = DateTime.Parse(input);
            DateTime dob_year = new DateTime(DateTime.Now.Year, dob.Month, dob.Day);

            if( dob_year > DateTime.Now )
            {
                Console.WriteLine("Ngày sinh nhật sắp tới, còn " + (dob_year - DateTime.Now).TotalDays);
            }
            else if( dob_year == DateTime.Now.Date)
            {
                Console.WriteLine("Chuc mung sinh nhat ban:!");
            }
            else
            {
                dob_year = dob.AddYears(1);
                Console.WriteLine("Ngay sinh nhat sap toi, con " + (dob_year - DateTime.Now.Date).TotalDays);
            }
            Console.WriteLine("dob: " + dob.ToString());
            Console.ReadKey();
        }
            
    }
}
