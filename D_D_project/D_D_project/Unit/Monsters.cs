namespace D_D_project.Unit;

public abstract class Monster : Unit
{
    public IItem? Loot { get; }
    public int XpReward { get; }

    protected Monster(string name, int health, int attackPower, int xpReward, IItem? loot = null)
        : base(name, health, attackPower)
    {
        XpReward = xpReward;
        Loot = loot;
    }
}