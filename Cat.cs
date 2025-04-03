using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
    public class Cat : Animal
    {
        public override string GetType()
        {
            return "Cat";
        }

        public override string GetSound()
        {
            return "Meow";
        }
    }
}
