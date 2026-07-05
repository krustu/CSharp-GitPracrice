using System;

class RPG
{
    public static List<Character> npc = new List<Character>();
    public static void Main()
    {
        List<ILootable> lootables = new();

        
        // more browlers
        Goblins g1 = new Goblins
        {
            Name = "Kiwi",
            HP = 100,
            Damage = 10,
            Level = 1
        };

        npc.Add(g1);
        lootables.Add(g1);

        Goblins g2 = new Goblins
        {
            Name = "sally",
            HP = 100,
            Damage = 10,
            Level = 1
        };
        npc.Add(g2);
        lootables.Add(g2);
        

        foreach (var item in lootables)
        {
            Console.WriteLine(item.GetLoot());
        }


        // fight 
        // unique mechanice 

        g1.atk(g2);
        g2.showstatus();
        
    }
    
}
interface ILootable
{
    string GetLoot(); //////////////////////////////////////////////////////////
}
 class Character
{
     public Character()
    {
        RPG.npc.Add(this);
    }
    public string ?Name{get ; set; }
    public int HP{get; set;}
    public int Damage{get; set;}
    public int Level{get; set;}

     public virtual void atk( Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with {Damage} damage.");
        target.takedmg((int)Damage);
    }
     public virtual void takedmg( int Damage )
    {
        this.Damage = Damage;
        HP -= Damage;
    }
     public virtual void showstatus()
    {
        Console.WriteLine($"Name-{Name} ");
        Console.WriteLine($"HP-{HP} ");
        Console.WriteLine($"Damage-{Damage}");
        Console.WriteLine($"LVl-{Level}");
    }
     
}



class Goblins : Character , ILootable
{
    public string GetLoot()
    {
        return "Goblin dildo"; //////////////////////////////////////////
    }
    //chance to hide attack 
    class Boss : Goblins
    {
       public override void takedmg( int Damage)
        {
            Damage /= 3;
            base.takedmg(Damage);
        }
    }
    class MaxGoblins : Goblins
    {
        
    }
}
class Humans : Character
{
    // uniqe power 
    // ability to improve skills
    // another skills

}
class Ogrs : Character , ILootable
{
    public string GetLoot()
    {
        return "Ogr Fang";
    }
   
    
    //extra hp
    //weakness from some peaples
}