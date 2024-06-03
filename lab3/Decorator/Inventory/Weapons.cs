using Heroes;
using System;

namespace Inventory
{
    public class Weapons : Inventory
    {
        private int numPower = 25;

        public Weapons(Hero hero) : base(hero)
        {
            _hero.SetPower(_hero.Power + numPower);
        }

        public override int GetPower()
        {
            Console.WriteLine($"Weapons add {numPower} power");
            Console.WriteLine($"Now Power is {_hero.Power}");
            return _hero.Power;
        }

        public override int GetEnergy()
        {
            Console.WriteLine("Weapons doesn't add energy");
            Console.WriteLine($"Now Energy is {_hero.Energy}");
            return _hero.Energy;
        }
    }
}
