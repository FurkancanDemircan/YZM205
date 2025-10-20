
public class Character
{
    public string Name { get; set; }
    protected int Health { get; set; }
    protected int Damage { get; set; }
    protected int Level { get; set; }

    public Character(string name, int health, int damage, int level)
    {
        Name = name;
        Health = health;
        Damage = damage;
        Level = level;
    }

    public void Attack(Character target)
    {
        Console.WriteLine($"{Name} attack {target.Name} deals {Damage} damage!");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int amount)
    {
        Health = Health - amount;
        if (Health < 0)
            Health = 0;
        Console.WriteLine($"{Name}’s remaining health: {Health}");
    }

    public void DisplayStats()
    {
        Console.WriteLine($"{Name} {Health} {Damage} {Level}");
    }

    public bool IsAlive => Health > 0;
}