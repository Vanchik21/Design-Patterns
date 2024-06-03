using System;
using Heroes;
using Inventory;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero mage = new Mage();
            mage = new Artefact(mage);
            mage = new Clothes(mage);
            mage = new Weapons(mage);
            mage.GetPower();
            mage.GetEnergy();

            Hero palladin = new Palladin();
            palladin = new Artefact(palladin);
            palladin.GetPower();
            palladin.GetEnergy();

            Hero warrior = new Warrior();
            warrior = new Clothes(warrior);
            warrior = new Weapons(warrior);
            warrior.GetPower();
            warrior.GetEnergy();
        }
    }
}
