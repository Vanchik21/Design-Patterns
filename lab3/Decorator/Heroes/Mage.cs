using System;

namespace Heroes
{
    public class Mage : Hero
    {
        public Mage()
        {
            this.Power = 50;
            this.Energy = 50;
        }

        public override int GetPower()
        {
            Console.WriteLine($"Mage has {Power} power");
            return this.Power;
        }

        public override int GetEnergy()
        {
            Console.WriteLine($"Mage has {Energy} energy");
            return this.Energy;
        }
    }
}
