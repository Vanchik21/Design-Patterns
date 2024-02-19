using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public abstract class Case
    {
        protected int idCase;
        protected string manufacturingMaterial;

        public Case(int idCase, string manufacturingMaterial)
        {
            this.idCase = idCase;
            this.manufacturingMaterial = manufacturingMaterial;
        }

        public string ManufacturingMaterial()
        {
            return manufacturingMaterial;
        }
    }
}
