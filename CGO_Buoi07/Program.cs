using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the width: ");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = Double.Parse(Console.ReadLine());
            Rectangle hinhchunhat = new Rectangle(width, height);
            Console.WriteLine("Hinh chu nhat \n" + hinhchunhat.Display());
            Console.WriteLine("Chu vi hinh chu nhat: " + hinhchunhat.GetPerimeter());
            Console.WriteLine("Dien tich hinh chu nhat: " + hinhchunhat.GetArea());
            Console.ReadKey();
        }
      
    }

    public class Rectangle
    {
        double width, height;

        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return this.width * this.height;
        }

        public double GetPerimeter()
        {
            return (this.width + this.height) * 2;
        }

        public String Display()
        {
            return "Rectangle{" + "chieu rong = " + width + ", chieu dai = " + height + "}";
        }
        
    }
  
}
         

