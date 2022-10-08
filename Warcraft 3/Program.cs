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
            footman.RageActivationEvent += Rage;
            mage.RageActivationEvent += Rage;
            peasant.Mining();
            peasant.Build();
            peasant.Cancel();
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            footman.Attack(mage);
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
            static void Rage(Footman footman, string Name)
            {
                if(!footman.IsInRage)
                {
                    Console.WriteLine($"{Name} in rage");
                    footman.Damage += 5;
                    footman.IsInRage = true;
                }
            }
        }
    }
}




