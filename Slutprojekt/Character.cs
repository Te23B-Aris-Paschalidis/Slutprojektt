using System;

namespace Slutprojekt;

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
    }
}
