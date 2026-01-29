using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Weapons
{
    public class Sword : IItem, IEquippable
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
