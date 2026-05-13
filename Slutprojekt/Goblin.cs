using System;

namespace Slutprojekt;

public class Goblin : Enemy
{
 public Goblin() : base("Goblin", 25, 4, 8)
    {
        
    }

    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "attackerar två gånger!");
        target.TakingDamage(Damage);
        target.TakingDamage(Damage);
    }
}
