using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Peasant : Unit
    {
        public Peasant() : base(20, 20, 5, 5, 0, 0, 100, 50)
        {

        }

        public static void Mining()
        {
            Console.WriteLine("Добывает");
        }

        public static void Build()
        {
            Console.WriteLine("Строит");
        }

        public static void Cancel()
        {
            Console.WriteLine("Отменяет");
        }
    }
}
