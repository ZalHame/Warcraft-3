using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Mage : Unit
    {
        public int Mana = 100;
        public Mage() : base(50, 50, 20, 20, 200, 250)
        {

        }

        public void TargetHeal(Unit unit)
        {
            int MaxHeal = 25;
            int Heal = unit.MaxHealth - unit.Health;
            if ((Heal <= MaxHealth) & (Mana - Heal * 2 >= 0))
            {
                unit.Health += Heal;
                Mana -= Heal * 2;
            }
            else if ((Mana - Heal * 2 < 0) & (Heal <= MaxHealth))
            {
                int ManaHeal = Mana / 2;
                unit.Health += ManaHeal;
            }
            else if ((Heal > MaxHealth) & (Mana - Heal * 2 >= 0))
            {

            }

            Console.WriteLine(unit + " get " + Heal + " heal");
        }
    }
}