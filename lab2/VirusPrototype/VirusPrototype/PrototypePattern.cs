using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusPrototype
{
    public class Virus
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string species)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Species = species;
            Children = new List<Virus>();
        }

        public Virus Clone()
        {
            Virus clonedVirus = (Virus)this.MemberwiseClone();
            clonedVirus.Children = new List<Virus>();
            foreach (Virus child in this.Children)
            {
                clonedVirus.Children.Add(child.Clone());
            }
            return clonedVirus;
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public override string ToString()
        {
            return $"{Name} ({Species}), Weight: {Weight}, Age: {Age}, Children: {Children.Count}";
        }
    }
}