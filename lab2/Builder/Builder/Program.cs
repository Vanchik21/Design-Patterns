using System;
using Builder;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacterBuilder heroBuilder = new HeroBuilder();
            Director director = new Director(heroBuilder);
            Character hero = director.ConstructHero();
            Console.WriteLine("Hero:");
            Console.WriteLine(hero.ToString());

            ICharacterBuilder enemyBuilder = new EnemyBuilder();
            director = new Director(enemyBuilder);
            Character enemy = director.ConstructEnemy();
            Console.WriteLine("\nEnemy:");
            Console.WriteLine(enemy.ToString());
        }
    }
}