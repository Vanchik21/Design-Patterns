using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string VetPassport { get; set; }

        public Animal(string name, string vetPassport)
        {
            Name = name;
            VetPassport = vetPassport;
        }

        public abstract bool IsFlying();
    }
}
