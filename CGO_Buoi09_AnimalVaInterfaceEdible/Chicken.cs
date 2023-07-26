using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi09_AnimalVaInterfaceEdible
{
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
        public string HowToEat()
        {
            return "could be fried";
        }
    }        
}
