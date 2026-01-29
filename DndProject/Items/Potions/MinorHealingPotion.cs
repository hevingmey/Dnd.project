using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Potions
{
    public class MinorHealingPotion : IItem, IUsable
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
