using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Build
    {
        public int Health;
        public int MaxHealth;
        public int Damage;
        public int MaxDamage;
        public int Defence;
        public int MaxDefence;
        public int Cost;

        public Build(int Health, int MaxHealth, int Damage, int MaxDamage, int Defence, int MaxDefence, int Cost)
        {
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Damage = Damage;
            this.MaxDamage = MaxDamage;
            this.Defence = Defence;
            this.MaxDefence = MaxDefence;
            this.Cost = Cost;
        }
    }
}
