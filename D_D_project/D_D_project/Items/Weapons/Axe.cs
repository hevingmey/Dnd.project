using D_D_project.Interfaces;
using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_D_project.Items.Weapons
{
    public class Axe : IItem
    {
        public string Name => "Thunderaxe";
        public string Description => "A massive axe humming with energy. Attack bonus: +15.";

        public int AttackBonus => 15;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} wields the {Name}!");
            Console.WriteLine("The axe is heavy but powerful!");

        }

        public void Unequip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} puts down the {Name}!");
        }
    }
}
