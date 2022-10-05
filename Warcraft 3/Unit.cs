using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Unit
    {
        public int Health;
        public int MaxHealth;
        public int Damage;
        public int MaxDamage;
        public int Defence;
        public int MaxDefence;
        public string Name;
        public static int Level = 1;
        public static List<Unit> UnitList = new List<Unit>();

        /*public Unit(int Health, int MaxHealth, int Damage, int MaxDamage, int Defence, int MaxDefence)
        {
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Damage = Damage;
            this.MaxDamage = MaxDamage;
            this.Defence = Defence;
            this.MaxDefence = MaxDefence;
            UnitList.Add(this);
        }*/
        public Unit(int MaxHealth, int MaxDamage, int MaxDefence, string Name)
        {
            this.Health = MaxHealth;
            this.MaxHealth = MaxHealth;
            this.Damage = MaxDamage;
            this.MaxDamage = MaxDamage;
            this.Defence = MaxDefence;
            this.MaxDefence = MaxDefence;
            this.Name = Name;
            UnitList.Add(this);
        }

        public void Attack(Unit unit)
        {
            if (this.Health > 0)
            {
                TakeDamage(unit);
            }
            else
            {
                this.Health = 0;
                Console.WriteLine("Your unit dead");
            }
        }

        private void TakeDamage(Unit unit)
        {
            if (unit.Health > 0)
            {
                unit.Health = unit.Health - (this.Damage - unit.Defence);
                Console.WriteLine(unit + " take " + (this.Damage - unit.Defence) + " damage");
            }
            else
            {
                Console.WriteLine("This " + unit + " dead");
            }
        }

        public void Attack_Build(Build build)
        {
            if (this.Health > 0)
            {
                TakeDamage_Build(build);
            }

            else
            {
                this.Health = 0;
                Console.WriteLine("This unit dead");
            }
        }

        private void TakeDamage_Build(Build build)
        {
            if (build.Health > 0)
            {
                build.Health = build.Health - (this.Damage - build.Defence);
                Console.WriteLine(build + " take " + (this.Damage - build.Defence) + " damage");
            }
            else
            {
                Console.WriteLine("This " + build + " destroy");
            }
        }
    }
}
