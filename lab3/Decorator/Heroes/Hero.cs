using System;

namespace Heroes
{
    public abstract class Hero
    {
        public int Power { get; protected set; }
        public int Energy { get; protected set; }

        public void SetPower(int power)
        {
            this.Power = power;
        }

        public void SetEnergy(int energy)
        {
            this.Energy = energy;
        }

        public abstract int GetPower();
        public abstract int GetEnergy();
    }
}