using Heroes;
using System;

namespace Inventory
{
    public abstract class Inventory : Hero
    {
        protected Hero _hero;

        public Inventory(Hero hero)
        {
            _hero = hero;
        }

        public override int GetPower()
        {
            return _hero.GetPower();
        }

        public override int GetEnergy()
        {
            return _hero.GetEnergy();
        }
    }
}
