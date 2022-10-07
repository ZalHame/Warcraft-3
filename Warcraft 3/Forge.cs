using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Forge : Build
    {
        public Forge() : base(500, 500, 0, 0, 4, 4, 400)
        {
            
        }

        public void Upgrade()
        {
            if (Unit.Level > 3)
            {
                return;
            }
            Unit.Level += 1;
            UpFootman();
            UpMage();
            UpPeasant();
            foreach (Unit unit in Unit.UnitList)
            {
                UpUnit(unit);
            }
        }

        public void UpUnit(Unit unit)
        {
            switch (unit.Name)
            {
                case "Footman": ListUpFootman(unit as Footman); break;
                case "Mage": ListUpMage(unit as Mage); break;
                case "Peasant": ListUpPeasant(unit as Peasant); break;
                default: break;
            }
        }

        private static void UpFootman()
        {
            Footman.maxhealth += 50;
            Footman.maxdamage += 5;
            Footman.maxdefence += 1;
        }
        private static void ListUpFootman(Footman unit)
        {
            unit.MaxHealth += 50;
            unit.Health += 50;
            unit.MaxDamage += 5;
            unit.Damage += 5;
            unit.MaxDefence += 1;
            unit.Defence += 1;
        }

        private static void UpMage()
        {
            Mage.maxhealth += 25;
            Mage.maxdamage += 10;
            Mage.maxmana += 50;
        }
        private static void ListUpMage(Mage unit)
        {
            unit.MaxHealth += 25;
            unit.Health += 25;
            unit.MaxDamage += 10;
            unit.Damage += 10;
            unit.MaxMana += 50;
            unit.Mana += 50;
        }

        private static void UpPeasant()
        {
            Peasant.maxhealth += 20;
            Peasant.maxdamage += 5;
        }
        private static void ListUpPeasant(Peasant unit)
        {
            unit.MaxHealth += 20;
            unit.Health += 20;
            unit.MaxDamage += 5;
            unit.Damage += 5;
        }
    }
}