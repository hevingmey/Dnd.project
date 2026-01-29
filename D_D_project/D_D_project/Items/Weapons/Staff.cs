using D_D_project.Interfaces;
using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_D_project.Items.Weapons
{
    public class Staff : IItem
    {
        public string Name => "Staff of Starfall";
        public string Description { get; set; } = "A staff inlaid with stars. Attack bonus: +10, enhances magic.";

        public int AttackBonus => 10;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} takes hold of the {Name}!");
            Console.WriteLine("The staff fills with magical energy!");

        }

        public void Unequip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} puts down the {Name}!");
        }
    }
}
