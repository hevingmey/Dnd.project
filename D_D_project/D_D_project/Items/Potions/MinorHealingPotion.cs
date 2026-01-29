using D_D_project.Interfaces;
using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_D_project.Items.Potions
{
    public class MinorHealingPotion : IItem
    {
        public string Name => "Purity Infusion";
        public string Description => "A small vial with a healing infusion. Heals 15 HP.";

        public void Use(Hero hero)
        {
            Console.WriteLine($"{hero.Name} drink the {Name}!");
            hero.Heal(15);
        }
    }
}
