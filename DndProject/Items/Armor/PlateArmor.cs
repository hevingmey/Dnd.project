using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Armor
{
    public class PlateArmor : IItem, IEquippable
    {
        public string Name => "Панцир Базиліска";
        public string Description => "Важкі пластини з каменіючої шкіри базиліска. Захист: 12.";

        public int Defense => 12;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} надіває {Name}!");
            Console.WriteLine("Броня важка, але надійна!");
            
        }

        public void Unequip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} знімає {Name}!");
            
        }

        public int CalculateDamage(int incomingDamage)
        {
            int finalDamage = incomingDamage - Defense;
            return finalDamage > 0 ? finalDamage : 1;
        }
    }
}
