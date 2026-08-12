public abstract class Character : IDestructible
{
    public string Name{get;set;}="";
    public int Health{get;set;}
    public abstract void Attack();
    public virtual void TakeDamage(int damage)
    {
        Console.WriteLine($"{Name}'s Health: {Health}");
        Health -= damage;
    }

}