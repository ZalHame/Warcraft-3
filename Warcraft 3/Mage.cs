using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Mage : Unit
    {

        public static int maxmana = 100;
        public int MaxMana = maxmana;
        public int Mana = maxmana;
        public static int maxhealth = 50;
        public static int maxdamage = 20;
        public static int maxdefence = 1;
        public Mage() : base(maxhealth, maxdamage, maxdefence, "Mage")
        {

        }

        public void TargetHeal(Unit unit)
        {
            int MaxHeal = 25;
            int Heal = unit.MaxHealth - unit.Health;

            if (unit.Health > 0)
            {
                if ((Heal <= MaxHeal) & (Mana - Heal >= 0))
                {
                    unit.Health += Heal;
                    Mana -= Heal;
                }
                else if ((Mana - Heal < 0) & (Heal <= MaxHeal))
                {
                    Heal = Mana;
                    unit.Health += Heal;
                    Mana -= Heal;
                }
                else if ((Heal > MaxHeal) & (Mana - Heal >= 0))
                {
                    Heal = MaxHeal;
                    unit.Health += Heal;
                    Mana -= Heal;
                }
                else if ((Mana - Heal < 0) & (Heal > MaxHeal))
                {
                    Heal = Mana;
                    unit.Health += Heal;
                    Mana -= Heal;
                }

                Console.WriteLine(unit + " get " + Heal + " heal");
            }
            else
            {
                Console.WriteLine("This unit dead");
            }
        }
    }
}