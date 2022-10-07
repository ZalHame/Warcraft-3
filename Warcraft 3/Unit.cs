using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Unit
    {
        public int _health { get; set; }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                int currentHealth = _health;
                if (value < 0) { _health = 0; }
                else { _health = value; }
                HealthChangedEvent?.Invoke(_health, MaxHealth, currentHealth, this.Name);
            }
        }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int MaxDamage { get; set; }
        public int Defence { get; set; }
        public int MaxDefence { get; set; }
        public string Name { get; set; }
        public static int Level = 1;
        public static List<Unit> UnitList = new List<Unit>();
        public delegate void HealthChangedDelegate(int Health, int MaxHealth, int currentHealth, string Name);
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

        public event HealthChangedDelegate HealthChangedEvent;
    }
}
