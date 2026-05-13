using System;

namespace Slutprojekt;
//Enemy
public class Enemy : Character
{
public int GoldReward;
public int Damage;

public Enemy(string name, int hp, int damage, int gold) : base(name, hp)
    {
        Damage = damage;
        GoldReward = gold;
    }

    public override void Attack(Character target)
    {
        Console.WriteLine(Name + "attackerar " + target.Name + "!");
    }
}
