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
        int MoveSpeed;
        int Cost;
        public Unit(int Health, int MaxHealth, int Damage, int MaxDamage, int Defence, int MaxDefence, int MoveSpeed, int Cost)
        {
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Damage = Damage;
            this.MaxDamage = MaxDamage;
            this.Defence = Defence;
            this.MaxDefence = MaxDefence;
            this.MoveSpeed = MoveSpeed;
            this.Cost = Cost;
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

        public void TakeDamage(Unit unit, int MyAttack)
        {
            unit.Health = MyAttack - unit.Defence;
        }

        public void Attack_Build(Build build)
        {
            if (this.Health > 0)
            {
                build.Health -= this.Damage;
                Console.WriteLine(build + " take " + this.Damage + " damage");
            }

            else
            {
                this.Health = 0;
                Console.WriteLine("This unit dead");
            }
        }
    }
}
