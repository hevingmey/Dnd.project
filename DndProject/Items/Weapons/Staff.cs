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
        public string Name => "Жезл Зоряного Пола";
        public string Description => "Жезл, інкрустований зірками. Бонус атаки: +10, + до магії.";

        public int AttackBonus => 10;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} бере в руки {Name}!");
            Console.WriteLine("Жезл наповнюється магічною енергією!");
            
        }

        public void Unequip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} кладе {Name}!");
            
        }
    }
}
