using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public class Aviary : Case
    {
        protected double volume {  get; set; }

        public Aviary(int idcase, string manufacturingMaterial, double volume) : base(idcase, manufacturingMaterial)
        {
            this.volume = volume;
        }
    }
}
