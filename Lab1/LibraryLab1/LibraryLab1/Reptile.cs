using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public class Reptile : Animal
    {
        public Reptile(string name, string vetPassport) : base(name, vetPassport) { }

        public override bool IsFlying()
        {
            return false;
        }
    }
}
