using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public class Bird : Animal
    {
        public bool isFlying;

        public Bird(string name, string vetPassport, bool isFlying) : base(name, vetPassport)
        {
            this.isFlying = isFlying;
        }

        public override bool IsFlying()
        {
            return isFlying;
        }
    }
}
