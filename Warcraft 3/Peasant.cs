using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Peasant : Unit
    {
        public static int maxhealth = 20;
        public static int maxdamage = 5;
        public static int maxdefence = 0;
        public Peasant() : base(maxhealth, maxdamage, maxdefence, "Peasant")
        {

        }

        public void Mining()
        {
            Console.WriteLine("Добывает");
        }

        public void Build()
        {
            Console.WriteLine("Строит");
        }

        public void Cancel()
        {
            Console.WriteLine("Отменяет");
        }
    }
}
