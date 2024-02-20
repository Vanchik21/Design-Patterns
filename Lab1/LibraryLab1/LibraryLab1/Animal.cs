using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public string VetPassport { get; private set; }

        public Animal(string name, string vetPassport)
        {
            Name = name;
            VetPassport = vetPassport;
        }

        public abstract bool CanFly();
    }
}
