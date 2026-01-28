using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndProject.Interfaces
{
    public interface IEquippable
    {
        void Equip(Hero hero);
        void Unequip(Hero hero);
    }
}
