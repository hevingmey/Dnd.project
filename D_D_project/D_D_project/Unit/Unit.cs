using D_D_project.Interfaces;  


namespace D_D_project.Unit;

public abstract class Unit
{
    private int health;
    public int LastAttackDamage { get; protected set; }
    public List<IItem> Inventory { get; } = new();

    public string Name { get; }
    public int Health => health;
    public int AttackPower { get; protected set; }
    public bool IsAlive => health > 0;

    protected Unit(string name, int health, int attackPower)
    {
        Name = name;
        this.health = Math.Max(0, health);
        AttackPower = Math.Max(0, attackPower);
    }

    public virtual void TakeDamage(int damage)
    {
        if (damage < 0) damage = 0;
        health = Math.Max(0, health - damage);
    }


    public void Heal(int amount)
    {
        if (amount < 0) amount = 0;
        health += amount;
    }

    public abstract void Attack(Unit target);
}
