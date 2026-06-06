using System;
using System.Dynamic;
using System.Collections.Generic;
class HighMegium
{
    static void Main()
    {
        
    }
}

class Character
{
    public string? Name {get; set;}
    public int Health {get; set;}

    public virtual void Attack()
    {
        
    }

}

class Warrior : Character
{
    public override void Attack()
    {
       // base.Attack();
    }
}
class Archer : Character
{
    public override void Attack()
    {
       // base.Attack();
    }
}
class Mage : Character
{
    public override void Attack()
    {
       // base.Attack();
    }
}