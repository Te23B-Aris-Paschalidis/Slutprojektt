using System;

namespace Slutprojekt;
//Basklass för alla varelser
public abstract class Character
{
public string Name;
public int Health;
public int MaxHealth;

public Character(string name, int hp)
    {
        Name = name;
        Health = hp;
        MaxHealth = hp;
    }
    public bool IsAlive() {return Health > 0;}

    public void TakingDamage(int amount)
    {
        Health = Health - amount;
        if (Health < 0 ) Health = 0;
        Console.WriteLine(Name + "tar " + amount + "skada! (" + Health + "/" + MaxHealth + "HP)");
    }
    public void Heal(int amount)
    {
        Health = Health + amount;
        if (Health > MaxHealth) Health = MaxHealth;
        Console.WriteLine(Name + "läker " + amount + " HP!");
    }
    public abstract void Attack(Character target);
}
