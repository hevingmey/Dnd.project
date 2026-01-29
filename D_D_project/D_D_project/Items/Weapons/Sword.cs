using D_D_project.Interfaces;
using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_D_project.Items.Weapons
{
    public class Sword : IItem
    {
        public string Name => "Sword of the Sun";
        public string Description => "A sword that shines like the sun. Attack bonus: +12.";

        public int AttackBonus => 12;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} draws the {Name}!");

        }

        public void Unequip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} sheathes the  {Name}!");

        }
    }
}
