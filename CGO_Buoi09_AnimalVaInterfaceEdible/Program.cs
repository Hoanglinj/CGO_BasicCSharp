using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi09_AnimalVaInterfaceEdible
{
    class AbstractAndInterfaceTests
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.HowToEat());
                }
                Console.ReadKey();
            }
        }
    }
}
