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
        public string Name => "Кров Дракона";
        public string Description => "Густа червона рідина, що пульсує теплом. Лікує 30 HP.";

        public void Use(Hero hero)
        {
            Console.WriteLine($"{hero.Name} випив(ла) {Name}!");
            hero.Heal(30);
        }
    }
}
