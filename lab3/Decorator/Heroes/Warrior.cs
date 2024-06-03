using Heroes;
using System;

namespace Heroes
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            this.Power = 150;
            this.Energy = 150;
        }

        public override int GetPower()
        {
            Console.WriteLine($"Warrior has {Power} power");
            return this.Power;
        }

        public override int GetEnergy()
        {
            Console.WriteLine($"Warrior has {Energy} energy");
            return this.Energy;
        }
    }
}
