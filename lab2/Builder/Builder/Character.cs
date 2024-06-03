using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public double Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; }

        public Character()
        {
            Inventory = new List<string>();
        }

        public override string ToString()
        {
            return $"Height: {Height}, BodyType: {BodyType}, HairColor: {HairColor}, EyeColor: {EyeColor}, Clothing: {Clothing}, Inventory: {string.Join(", ", Inventory)}";
        }
    }
}
