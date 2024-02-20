using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public abstract class Animal
    {
        protected string name;
        protected string vetPassport;

        public Animal(string name, string vetPassport) 
        { 
            this.name = name;
            this.vetPassport = vetPassport;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string VetPassport
        {
            get { return vetPassport; }
            set { vetPassport = value; }
        }

        public abstract bool IsFlying();
    }
}
