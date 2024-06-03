using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
        public class Director
        {
            private ICharacterBuilder _builder;

            public Director(ICharacterBuilder builder)
            {
                _builder = builder;
            }

            public Character ConstructHero()
            {
                return _builder
                    .SetHeight(1.8)
                    .SetBodyType("Athletic")
                    .SetHairColor("Blonde")
                    .SetEyeColor("Blue")
                    .SetClothing("Armor")
                    .AddInventoryItem("Sword")
                    .AddInventoryItem("Shield")
                    .Build();
            }

            public Character ConstructEnemy()
            {
                return _builder
                    .SetHeight(2.0)
                    .SetBodyType("Muscular")
                    .SetHairColor("Black")
                    .SetEyeColor("Red")
                    .SetClothing("Dark Armor")
                    .AddInventoryItem("Axe")
                    .AddInventoryItem("Potion")
                    .Build();
            }
        }
}
