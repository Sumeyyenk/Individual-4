public class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} casts a fireball!");
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"{Name} took {damage} damage. Remain Health: {Health}");
    }
}