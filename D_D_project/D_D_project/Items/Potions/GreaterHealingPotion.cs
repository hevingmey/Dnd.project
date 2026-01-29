using D_D_project.Interfaces;
using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_D_project.Items.Potions
{
    public class GreaterHealingPotion : IItem
    {
        public string Name => "Phoenix Heart";
        public string Description => "A glowing elixir containing a fragment of immortality. Heals 50 HP.";

        public void Use(Hero hero)
        {
            Console.WriteLine($"{hero.Name} drinks the {Name}!");
            hero.Heal(50);
            Console.WriteLine("A surge of energy flows through you!");
        }
    }
}
