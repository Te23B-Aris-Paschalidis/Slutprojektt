using System;

namespace Slutprojekt;
//spelaren
public class Player : Character
{
   public int Gold;
   public List<string> Inventory = new List<string>();
   
   public Player(string name) : base(name, 100) {Gold = 100}

    public override void Attack(Character target)
    {
    Console.WriteLine(Name + "attackerar " + target.Name + "!");
    target.TakingDamage(10);
    }


}
