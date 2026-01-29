using D_D_project.Unit;
using System;
using System.Collections.Generic;
using System.Text;
using D_D_project.Unit;

namespace D_D_project.Interfaces
{
    public interface IItem
    {
        string Name { get; }
        string Description { get; }
    }
    public interface IUsable
    {
        void Use(D_D_project.Unit.Unit unit);
    }

    public interface IEquippable
    {
        void Equip(Hero hero);
    }
}
