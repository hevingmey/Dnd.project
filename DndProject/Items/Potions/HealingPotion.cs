using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Potions
{
    public class HealingPotion : IItem, IUsable
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
