using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndProject.Interfaces;

namespace DndProject.Items.Potions
{
    public class GreaterHealingPotion : IItem, IUsable
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
