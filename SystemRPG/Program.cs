using System;

class RPG
{
    List<Character> npc = new List<Character>();
    static void Main()
    {
        
    }
    
}
class Character
{
    public string ?Name{get ; set; }
    public int HP{get; set;}
    public int Damage{get; set;}
    public int Level{get; set;}

     public virtual void atk( Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {Damage} damage.");
        target.takedmg((int)Damage);
    }
     public virtual void takedmg( int Damage )
    {
        this.Damage = Damage;
        HP -= Damage;
    }

}



class Goblins : Character
{
    class Boss : Goblins
    {
        
    }
    class MaxGoblins : Goblins
    {
        
    }
}
class Humans : Character
{
    
}
class Ogrs : Character
{
    
}