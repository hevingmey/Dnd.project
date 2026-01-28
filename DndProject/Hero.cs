using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndProject
{
    //тест
    public class Hero
    {
        public string Name { get; set; }
        public int Health { get; private set; } = 100;

        public Hero(string name)
        {
            Name = name;
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} +{amount} HP");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} -{damage} HP");
        }
    }
}
