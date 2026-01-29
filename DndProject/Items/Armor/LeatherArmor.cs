using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Armor
{
    public class LeatherArmor : IItem, IEquippable
    {
        public string Name => "Werewolf Hide";
        public string Description => "Light armor made from werewolf skin. Defense: 3.";

        public int Defense => 3;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} equips {Name}!");
            
        }

        public void Unequip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} unequips {Name}!");
            
        }

        public int CalculateDamage(int incomingDamage)
        {
            int finalDamage = incomingDamage - Defense;
            return finalDamage > 0 ? finalDamage : 1;
        }
    }
}
