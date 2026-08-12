List<Character> list = new List<Character>();

Warrior w = new Warrior {Name = "Warrior", Health = 200};
Mage m = new Mage {Name = "Mage",Health =150};
Tree t = new Tree();
list.Add(m);
list.Add(w);

foreach(Character c in list)
{
    c.Attack();
}
w.TakeDamage(50);
m.TakeDamage(50);
t.TakeDamage(50);