
namespace D_D_project.Unit;

public class Knight : Hero
{
    public Knight(string name)
        : base(name, health: 55, attackPower: 6)
    {
        
    }
    
    

    protected override void LevelUp()
    {
        base.LevelUp();
        AttackPower += 1;
    }

    public override void Attack(Unit target)
    {
        int roll =Random.Shared.Next(1,21);
        int damage;
        if (roll <=4) damage = 0; // промах 
        else if  (roll <=17) damage = AttackPower*2;  // double attack
        else  damage = AttackPower;  // normal attack 
        
        target.TakeDamage(damage);
    }
}

