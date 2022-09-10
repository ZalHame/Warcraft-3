using System;

namespace Warcraft_3
{
    class Program
    {
        static void Main()
        {
            Peasant peasant = new Peasant();
            Footman footman = new Footman();
            Mage mage = new Mage();
            /*Peasant.Mining();
            Peasant.Build();
            Peasant.Cancel();
            Console.WriteLine(mage.Health);
            Console.WriteLine(footman.Health);*/
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            mage.Attack(footman);
            footman.Attack(mage);
            Footman.Rage(footman);
            Console.WriteLine(footman.Health);
            //footman.Attack(mage);
            mage.TargetHeal(footman);
            Console.WriteLine(footman.Health);
            Console.WriteLine(mage.Mana);
        }
    }
}




