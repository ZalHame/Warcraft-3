using System;

namespace Warcraft_3
{
    class Program
    {
        static void Main()
        {
            Peasant peasant = new Peasant();
            Footman footman = new Footman();
            Mage mage = new Mage();
            mage.HealthChangedEvent += Info;
            footman.HealthChangedEvent += Info;
            peasant.HealthChangedEvent += Info;
            /*Peasant.Mining();
            Peasant.Build();
            Peasant.Cancel();
            Console.WriteLine(mage.Health);
            Console.WriteLine(footman.Health);*/
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            footman.Attack(mage);
            footman.Rage();
            Console.WriteLine(footman.Health);
            //footman.Attack(mage);
            mage.TargetHeal(footman);
            Console.WriteLine(footman.Health);
            Console.WriteLine(mage.Mana);

            static void Info(int health, int maxHealth, int currentHealth, string Name)
            {
                if (health < currentHealth)
                {
                    Console.WriteLine($"{Name} Recieved damage {currentHealth - health} ({maxHealth}/{health})");
                }
                else if (health > currentHealth)
                {
                    Console.WriteLine($"{Name} Healed health {health - currentHealth} ({maxHealth}/{health})");
                }
            }
        }
    }
}




