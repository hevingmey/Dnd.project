using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Weapons
{
    public class Axe : IItem, IEquippable
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
