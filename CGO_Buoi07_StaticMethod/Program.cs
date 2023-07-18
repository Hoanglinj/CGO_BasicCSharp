using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi07_StaticMethod
{
    internal class Program
    {
        public class Student
        {
            private int rollno;
            private string name;
            private static string college = "BBDIT";

            //constructor to initialize the variable
            public Student(int r, string n)
            {
                rollno = r;
                name = n;
            }

            //static method to change the value of static variable

            public static void Change()
            {
                college = "CODEGYM";
            }

            //method to display values
            public void Display()
            {
                Console.WriteLine(rollno + " " + name + " " + college);
            }
        }

        public class Type
        {
            public static void Main(string[] args)
            {
                Student.Change();
                Student s1 = new Student(111, "Linh");
                Student s2 = new Student(222, "Khanh");
                Student s3 = new Student(333, "Hoang");
                
                s1.Display();
                s2.Display();
                s3.Display();
            }
        }
    }
}

