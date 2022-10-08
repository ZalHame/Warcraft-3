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
            Peasant.Mining();
            Peasant.Build();
            Peasant.Cancel();
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            footman.Attack(mage);
            footman.Rage();
            footman.Attack(mage);
            mage.Attack(footman);
            mage.Attack(footman);
            footman.Attack(mage);
            mage.TargetHeal(footman);

            static void Info(int Health, int MaxHealth, int currentHealth, string Name)
            {
                if (Health < currentHealth)
                {
                    Console.WriteLine($"{Name} Recieved damage {currentHealth - Health} ({Health}/{MaxHealth})");
                }
                else if (Health > currentHealth)
                {
                    Console.WriteLine($"{Name} Healed health {Health - currentHealth} ({Health}/{MaxHealth})");
                }
            }
        }
    }
}




