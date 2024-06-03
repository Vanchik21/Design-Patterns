using Heroes;
using System;

namespace Heroes
{
    public class Palladin : Hero
    {
        public Palladin()
        {
            this.Power = 100;
            this.Energy = 100;
        }

        public override int GetPower()
        {
            Console.WriteLine($"Palladin has {Power} power");
            return this.Power;
        }

        public override int GetEnergy()
        {
            Console.WriteLine($"Palladin has {Energy} energy");
            return this.Energy;
        }
    }
}
