namespace D_D_project.Unit;

public class Mage : Hero
{
    public Mage(string name)
        : base(name, health: 32, attackPower: 10)
    {
    }

    protected override void LevelUp()
    {
        base.LevelUp();
        AttackPower += 2;
    }
    public override void Attack(Unit target)
    {
        int roll =Random.Shared.Next(1,21);
        int damage;
        if (roll <=4) damage = 0;
        else if  (roll >=17) damage = AttackPower*2;
        else  damage = AttackPower;
        
        target.TakeDamage(damage);
    }
}