namespace D_D_project.Unit;

public class Orc : Monster
{
    public Orc(IItem? loot = null)
        : base("Orc", health: 35, attackPower: 8, xpReward: 50, loot: loot)
    {
    }

    public override void Attack(Unit target)
    {
        if (!IsAlive || !target.IsAlive) return;


        int hits = Random.Shared.Next(1, 40);
        int damageM;
        if (hits <= 8)
            damageM = 0;
        else if (hits >= 12)
            damageM = AttackPower * 2;
        else damageM = AttackPower;

        
        target.TakeDamage(AttackPower);
    }
}