using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
   public class Dog : Animal
    {
        public override string GetType()
        {
            return "Dog";
        }

        public override string GetSound()
        {
            return "Bark";
        }
    }
}
