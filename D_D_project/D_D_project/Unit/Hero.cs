using D_D_project.Interfaces;
using System.Collections.Generic;
using D_D_project.Unit;

namespace D_D_project.Unit;

public abstract class Hero : Unit
{
    private int experience;

    public int Experience => experience;
    public int Level { get; private set; } = 1;

    public List<IItem> Inventory { get; } = new();

    protected Hero(string name, int health, int attackPower)
        : base(name, health, attackPower)
    {
    }

    public override void Attack(Unit target)
    {
        if (!IsAlive || !target.IsAlive) return;
        target.TakeDamage(AttackPower);
    }

    public void HealSelf()
    {   if (!IsAlive ) return;
        Heal(8);
    }

    public void GainExperience(int amount)
    { if (amount < 0) amount = 0;
        experience += amount;
        while (experience >= 100)
        {
            experience -= 100;
            LevelUp();
        }
    }

    protected virtual void LevelUp()
    {
        Level++;
        AttackPower += 2;
    }
}