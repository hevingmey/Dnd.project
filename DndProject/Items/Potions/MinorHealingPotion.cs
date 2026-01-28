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
        public string Name => "Настій Чистоти";
        public string Description => "Маленька пляшечка з цілющим настоєм. Лікує 15 HP.";

        public void Use(Hero hero)
        {
            Console.WriteLine($"{hero.Name} випив(ла) {Name}!");
            hero.Heal(15);
        }
    }
}
