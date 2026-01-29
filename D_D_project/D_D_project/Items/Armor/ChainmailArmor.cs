using D_D_project.Interfaces;
using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_D_project.Items.Armor
{
    public class ChainmailArmor : IItem
    {
        public string Name => "Forest Elf Chainmail";
        public string Description => "Durable chainmail woven by elven masters. Defense: 6.";

        public int Defense => 6;

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
