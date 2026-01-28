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
        public string Name => "Серце Фенікса";
        public string Description => "Сяючий еліксир з часткою безсмертя. Лікує 50 HP.";

        public void Use(Hero hero)
        {
            Console.WriteLine($"{hero.Name} випив(ла) {Name}!");
            hero.Heal(50);
            Console.WriteLine("Відчувається прилив сил!");
        }
    }
}
