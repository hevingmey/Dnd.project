using D_D_project.Interfaces;
namespace D_D_project.Unit;

public class Boss : Monster
{
    private int phase = 1;

    public Boss(IItem? loot = null)
        : base("Boss", health: 80, attackPower: 10, xpReward: 120, loot: loot)
    {
    }
    public override void Attack(Unit target)
    {
        if (!IsAlive || !target.IsAlive) return;


        int hits = Random.Shared.Next(1, 44);
        int damageM;
        if (hits <= 15)
            damageM = 0;
            // це для подвоєння удару при викиді більшої грані , можливо це зайве для мобів 
        // else if (hits >=20 )
        //     damageM = AttackPower * 2;
        else damageM = AttackPower;

        
        target.TakeDamage(AttackPower);
    }
                //phase batll це фази бою з босом може бути складно для реалізації в подальшому (не готове )
    // public override void Attack(Unit target)
    // {
    //     if (!IsAlive || !target.IsAlive) return;
    //
    //     UpdatePhase();
    //
    //     int damage = AttackPower;
    //
    //   
    //     if (phase >= 2)
    //     {
    //         bool crit = Random.Shared.Next(0, 100) < 30;
    //         if (crit) damage *= 2;
    //     }
    //
    //     target.TakeDamage(damage);
    // }
       //phase batll
    // private void UpdatePhase()
    // {
    //     
    //     if (phase == 1 && Health <= 40)
    //     {
    //         phase = 2;
    //         AttackPower += 3;
    //     }
    // }
}