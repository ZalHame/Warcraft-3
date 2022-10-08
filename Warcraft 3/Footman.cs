using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Footman : Unit
    {
        public static int maxhealth = 100;
        public static int maxdamage = 10;
        public static int maxdefence = 3;
        public Footman() : base(maxhealth, maxdamage, maxdefence, "Footman")
        {

        }

        public void Rage()
        {
            bool RageCondition = false;

            if ((this.Health <= this.MaxHealth / 4) && (RageCondition == false) && (this.Health > 0))
            {
                RageCondition = true;
                this.Damage += 5;
                Console.WriteLine("This footman fell into a RAGE");
            }
            else
            {
                RageCondition = false;
                this.Damage -= 5;
            }
        }
    }
}