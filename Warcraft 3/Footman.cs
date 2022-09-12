using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Footman : Unit
    {
        public Footman() : base(100, 100, 10, 10, 3, 3, 300, 150)
        {

        }

        public static void Rage(Footman unit)
        {
            bool RageCondition = false;

            if ((unit.Health <= unit.MaxHealth / 4) & (RageCondition == false))
            {
                RageCondition = true;
                unit.Damage += 5;
                Console.WriteLine("This footman fell into a RAGE");
            }
            else
            {
                RageCondition = false;
                unit.Damage -= 5;
            }
        }
    }
}