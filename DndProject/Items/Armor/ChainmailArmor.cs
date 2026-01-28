using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Armor
{
    public class ChainmailArmor : IItem, IEquippable
    {
        public string Name => "Кольчуга Лісового Ельфа";
        public string Description => "Міцна кольчуга, плетена ельфійськими майстрами. Захист: 6.";

        public int Defense => 6;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} надіває {Name}!");
            
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
