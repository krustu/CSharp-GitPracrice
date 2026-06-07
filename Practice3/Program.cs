using System;
using System.Dynamic;
using System.Collections.Generic;

namespace Practice3
{
class HighMegium
{
    static List<Character> Warriors = new List<Character>();
    static void Main()
    {
        Warrior Krustu = new Warrior { 
                                       Name = "KRustu", 
                                       Health = 210,  
                                       AttackDamage = 45 
                                     };
        Warriors.Add(Krustu); 

        Warrior Buble = new Warrior { 
                                       Name = "Buble", 
                                       Health = 130,  
                                       AttackDamage = 70 
                                     };
        Warriors.Add(Buble); 

        Archer Spongebob = new Archer { 
                                       Name = "Spongebob", 
                                       Health = 150,  
                                       AttackDamage = 60 
                                     };
        Warriors.Add(Spongebob);
        Mage Pat = new Mage { 
                                       Name = "Pat", 
                                       Health = 100,  
                                       AttackDamage = 80 
                                     };
        Warriors.Add(Pat);

       foreach (var warrior in Warriors)
        {
            Character.Info(warrior);
        }

        Console.WriteLine("\nBattle Begins!\n");

        Krustu.Attack(Spongebob);
        Spongebob.Attack(Krustu);
        Buble.Attack(Pat);
        Pat.Attack(Buble);

         Console.WriteLine("\nBattle Ends!\n");

         foreach (var warrior in Warriors)
        {
            Character.Info(warrior);
        }


    
     
    }
}

class Character
{
    public string? Name {get; set;}
    public int Health {get; set;}

    public int AttackDamage {get; set;}
    public virtual void Attack(Character target)
    {
        
        
        Console.WriteLine($"{Name} attacks {target.Name} for {AttackDamage} damage.");

        target.TakeDamage(AttackDamage);
    }
    

    public virtual int TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} has died.");
        }
        else
        {
            Console.WriteLine($"{Name} takes {damage} damage, remaining health: {Health}");
        }
        return Health;
    }
    public virtual bool IsAlive()
    {
        if (Health > 0)
        {
            Console.WriteLine($"{Name} is alive.");
        }
         else
        {
            Console.WriteLine($"{Name} is dead.");
        }
        return Health > 0;
    }


   /* public virtual void SpecialAbility()
    {
        Console.WriteLine($"{Name} uses their special ability.");
    }

*/

    public static void Info(Character character)
    {
        Console.WriteLine($"Name: {character.Name}, Health: {character.Health}");
    }


}



class Warrior : Character
{
    public override void Attack(Character target)
    {
         base.Attack(target);
    }
        public override int TakeDamage(int damage)
        {
            damage /= 2; 
            return base.TakeDamage(damage); 
        }
}


class Archer : Character
{
    public override void Attack(Character target)
    {
       base.Attack(target);
    }
        public override int TakeDamage(int damage)
        {
            damage = (int)(damage * 0.75);
            return base.TakeDamage(damage);
        }
}
class Mage : Character
{
    public override void Attack(Character target)
    {
        base.Attack(target);
    }
        public override int TakeDamage(int damage)
        {
            damage = (int)(damage * 0.5);
            return base.TakeDamage(damage);
        }
}
}
