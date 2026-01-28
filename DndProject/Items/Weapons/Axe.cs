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
        public string Name => "Сокира Громовержця";
        public string Description => "Велика сокира, що гудить від енергії. Бонус атаки: +15.";

        public int AttackBonus => 15;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} бере в руки {Name}!");
            Console.WriteLine("Сокира важка, але потужна!");
            
        }

        public void Unequip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} кладе {Name}!");
            
        }
    }
}
