public class Mage : Character
{
    private int Mana { get; set; }
    public Mage(string name, int health, int damage, int level, int mana)
        : base(name, health, damage, level)
    {
        Mana = mana;
    }

    public void CastSpell(Character target)
    {
        if (Mana >= 10)
        {
            Mana -= 10;
            Console.WriteLine($"{Name} casts a spell on {target.Name} for {Damage + 5} damage!");
            target.TakeDamage(Damage + 5);
            return;
        }
        Console.WriteLine($"{Name} is out of mana!");
    }

    public void RechargeMana(int amount)
    {
        Mana += amount;
        if (Mana >= 100)
            Mana = 100;
        Console.WriteLine($"{Name} recharge mana! Current mana: {Mana}!");
    }
}