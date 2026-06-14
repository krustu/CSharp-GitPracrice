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
    public float Damage{get; set;}
    public int Level{get; set;}

     public virtual void atk( Character target)
    {
        
    }
     public virtual void takedmg( int Damage )
    {
        this.Damage = Damage;
    }

}



class Goblins : Character
{
    
}
class Humans : Character
{
    
}
class Ogrs : Character
{
    
}