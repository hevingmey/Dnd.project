using D_D_project.Interfaces;
using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_D_project.Items.Armor
{
    public class PlateArmor : IItem
    {
        public string Name => "Basilisk Carapace";
        public string Description { get; set; } = "Heavy armor made of metal plates.";

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
