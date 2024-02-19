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

        public string GetName()
        {
            return name;
        }

        public string GetVetPassport()
        {
            return vetPassport;
        }
    }
}
