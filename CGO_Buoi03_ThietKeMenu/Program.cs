using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi03_ThietKeMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Hinh tam giac vuong tai:");
                        Console.WriteLine("01. top-left");
                        Console.WriteLine("02. top-right");
                        Console.WriteLine("03. botton-left");
                        Console.WriteLine("04. botton-right");
                        chontamgiac = Console.ReadLine();
                        switch (chotamgiac)
                        {
                            case 01:
                                Console.Write("Nhap vao so dong cua tam giac: ");
                                int rows = Convert.ToInt32(Console.ReadLine());
                                //sử dụng vòng lặp for thứ nhất để lặp qua các dòng
                                for (int i = 1; i <= rows; i++)
                                {
                                    //sử dụng vòng lặp for thứ hai để in ký tự * cho mỗi dòng
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write("*");
                                    }
                                    //sau khi in mỗi dòng sẽ xuống hàng
                                    Console.Write("\n");

                                }
                        }
                        
                        
                        Console.Write("Nhap vao so dong cua tam giac:");
                        int rows = Convert.ToInt32(Console.ReadLine());
                        //sử dụng vòng lặp for thứ nhất để lặp qua các dòng, ở đây ta sẽ lặp từ rows -> 1
                        for (int i = rows; i >= 1; i--)
                        {
                            //sử dụng vòng lặp for thứ hai để in ký tự * cho mỗi dòng
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            //sau khi in mỗi dòng sẽ xuống hàng
                            Console.Write("\n");
                        }
                        
                        break;
                    case 2:
                        Console.Write("Nhap vao so dong cua hinh chu nhat: ");
                        int rowschunhat = Convert.ToInt32(Console.ReadLine());
                        //sử dụng vòng lặp for thứ nhất để lặp qua các dòng
                        for (int i = 2; i <= rowschunhat; i++)
                        {
                            //sử dụng vòng lặp for thứ hai để in ký tự * cho mỗi dòng
                            for (int j = 1; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            //sau khi in mỗi dòng sẽ xuống hàng
                            Console.Write("\n");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
    }
}
