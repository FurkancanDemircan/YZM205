public class Warrior : Character
{
    private int Armor { get; set; }

    public Warrior(string name, int health, int damage, int level, int armor)
        : base(name, health, damage, level)
    {
        this.Armor = armor;
    }

    public void PowerAttack(Character target)
    {
        var damage = Damage + 10;
        Console.WriteLine($"{Name} performs a Power Attack on {target.Name} and deals {damage} damage!");
        target.TakeDamage(damage);
    }

    public void Defend(int amount)
    {
        var damage = amount * Armor / 100;
        TakeDamage(damage);
        Console.WriteLine($"{Name} defends with armor ({Armor / 100}% reduction)");
    }
}