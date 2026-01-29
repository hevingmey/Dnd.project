using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Weapons
{
    public class Staff : IItem, IEquippable
    {
        public string Name => "Staff of Starfall";
        public string Description => "A staff inlaid with stars. Attack bonus: +10, enhances magic.";

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
