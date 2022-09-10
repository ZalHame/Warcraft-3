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
        int Cost;

        public Build(int Health, int MaxHealth, int Damage, int MaxDamage, int Cost)
        {
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Damage = Damage;
            this.MaxDamage = MaxDamage;
            this.Cost = Cost;
        }

    }
}
