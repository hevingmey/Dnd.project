using D_D_project.Unit;
namespace D_D_project.Unit;

public class Goblin : Monster
{
    public Goblin(IItem? loot = null)
        : base("Goblin", health: 18, attackPower: 4, xpReward: 30, loot: loot)
    {
    }

    public override void Attack(Unit target)
    {
        if (!IsAlive || !target.IsAlive) return;


        int hits = Random.Shared.Next(1, 12);
        int damageM;
        if (hits <= 3)
            damageM = 0;
        else if (hits >= 9)
            damageM = AttackPower * 2;
        else damageM = AttackPower;

        
            target.TakeDamage(AttackPower);
    }
}