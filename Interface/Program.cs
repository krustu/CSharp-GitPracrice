using System;

class Interface
{
    static void Main()
    {
         Character MyNPC = new Character();
         
    }
}
interface IAttacker
{
    int AttackPower { get; }
    void Attack(IDamageable target);
}

interface IDamageable
{
    int Health { get; set; }
    void TakeDamage(int amount);
}

class Character : IAttacker, IDamageable
{
    public int Health { get; set; } = 100;
    public int AttackPower { get; set; } = 15;

    public void Attack(IDamageable target) => target.TakeDamage(AttackPower);
    public void TakeDamage(int amount) => Health -= amount;
}