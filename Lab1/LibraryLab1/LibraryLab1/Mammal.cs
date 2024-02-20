using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public class Mammal : Animal
    {
        public bool isFlying { get; private set; }

        public Mammal(string name, string vetPassport, bool canFly) : base(name, vetPassport)
        {
            this.isFlying = isFlying;
        }

        public override bool CanFly()
        {
            return isFlying;
        }
    }
}