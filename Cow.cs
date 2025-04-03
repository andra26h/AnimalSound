using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
    public class Cow : Animal
    {
        public override string GetType()
        {
            return "Cow";
        }

        public override string GetSound()
        {
            return "Moo";
        }
    }
}
