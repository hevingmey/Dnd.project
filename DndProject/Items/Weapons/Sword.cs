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
        public string Name => "Меч Сонця";
        public string Description => "Меч, що сяє як сонце. Бонус атаки: +12.";

        public int AttackBonus => 12;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} бере в руки {Name}!");
            
        }

        public void Unequip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} кладе {Name}!");
            
        }
    }
}
