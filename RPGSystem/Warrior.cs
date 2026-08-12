public class Warrior : Character
{
    public override  void Attack()
    {
        Console.WriteLine($"{Name} swings a heavy sword!");
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"{Name} took {damage} damage. Remain Health: {Health}");
    }
}