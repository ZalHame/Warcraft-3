using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Footman : Unit
    {
        int Armor = 5;
        public Footman() : base(100, 100, 10, 10, 300, 150)
        {

        }

        static public void Rage(int Damage)
        {
            Damage += 5;
        }
    }
}
