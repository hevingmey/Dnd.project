using D_D_project.Interfaces;
using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_D_project.Items.Potions
{
    public class HealingPotion : IItem
    {
        public string Name => "Dragon's Blood";
        public string Description => "A thick red liquid that pulses with warmth. Heals 30 HP.";

        public void Use(Hero hero)
        {
            Console.WriteLine($"{hero.Name} drinks the {Name}!");
            hero.Heal(30);
        }
    }
}
