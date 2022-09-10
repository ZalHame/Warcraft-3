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
        int MoveSpeed;
        int Cost;
        public Unit(int Health, int MaxHealth, int Damage, int MaxDamage, int MoveSpeed, int Cost)
        {
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Damage = Damage;
            this.MaxDamage = MaxDamage;
            this.MoveSpeed = MoveSpeed;
            this.Cost = Cost;
        }

        public void Attack(Unit unit)
        {
            if (this.Health > 0)
            {
                unit.Health -= this.Damage;
                Console.WriteLine(unit + " take " + this.Damage + " damage");
            }

            else
            {
                Console.WriteLine("This unit dead");
                this.Health = 0;
            }
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
                Console.WriteLine("This unit dead");
                this.Health = 0;
            }
        }
    }
}
