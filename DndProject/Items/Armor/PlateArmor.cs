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
        public string Name => "Basilisk Carapace";
        public string Description => "Heavy plates made from the petrifying skin of a basilisk. Defense: 12.";

        public int Defense => 12;

        public void Equip(Hero hero)
        {
            Console.WriteLine($"{hero.Name} equips {Name}!");
            Console.WriteLine("The armor is heavy but reliable!");
            
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
