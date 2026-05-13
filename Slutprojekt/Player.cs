using System;

namespace Slutprojekt;
//spelaren
public class Player : Character
{
   public int Gold;
   public List<string> Inventory = new List<string>();
   
   public Player(string name) : base(name, 100) { Gold = 0; }

    public override void Attack(Character target)
    {
    Console.WriteLine(Name + "attackerar " + target.Name + "!");
    target.TakingDamage(10);
    }

public void ShowStatus()
{
Console.WriteLine(Name + " - HP: " +  Health + "/" + MaxHealth + "Guld: " + Gold );
}
}

