using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Zoo
{
    List<Animal> allanimals = new List<Animal>();  // add static to fix or inherit from zoo and make it non static
    static void Main()
    {
      
         Zoo zoo = new Zoo();
         Animal cat = new Cat { Name = "Whiskers", Health = 100 };
         Animal dog = new Dog { Name = "Buddy", Health = 150 };
         Animal lion = new Lion { Name = "Simba", Health = 200 };
    
         zoo.allanimals.Add(dog);
         zoo.allanimals.Add(lion);
         zoo.allanimals.Add(cat);
       
       Console.WriteLine("Animal Sounds: ");
        foreach(var animal in zoo.allanimals)
        {
            animal.Sound();
        }
        Console.ReadKey();

        Console.WriteLine("Taking Damage: ");
        foreach(var animal in zoo.allanimals)
        {
            animal.TakeDamage(30);
        }
        
        Console.ReadKey();

        Console.WriteLine("Checking if Animals are Alive: ");
        foreach(var animal in zoo.allanimals)
        {
            animal.IsAlive();
        }
        /*Animal cat = new Cat();
        Animal dog = new Dog();
        Animal lion = new Lion();
        List<Animal> animals = new List<Animal> { cat, dog, lion };

        cat.TakeDamage(30);
        dog.TakeDamage(50);
        lion.TakeDamage(200);*/


        // zoo.allanimals[0].TakeDamage(30); // Cat takes damage // another way to do it is to loop through all animals and make them take damage
        // zoo.allanimals[1].TakeDamage(50); // Dog takes damage

        /*foreach(var animal in zoo.allanimals)
        {
            animal.TakeDamage(30);
        }

         Console.WriteLine("Checking if Animals are Alive: ");*/
        
    

    }

}

class Animal
{
    public string? Name{get; set; }
    public int Health{get; set;}

    public virtual void Sound()
    {
        Console.WriteLine($"{Name} makes a sound.");
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
}
class Cat : Animal
{
    public sealed override void Sound()
    {
        //base.Sound();
        
        Console.WriteLine($"{Name} says Meow!");
    }
    public sealed override int TakeDamage(int damage)
    {
        damage /= 2; // Cat takes half damage
        return base.TakeDamage(damage);
        
    
    }
}
class Dog : Animal
{
    public sealed override void Sound()
    {
        //base.Sound();
        Console.WriteLine($"{Name} says Woof!");
    }
    public sealed override int TakeDamage(int damage)
    {
        damage = (int)(damage * 0.75); // Dog takes 25% less damage
        return base.TakeDamage(damage);
        
    }

}
class Lion : Animal
{
    public sealed override void Sound()
    {
        //base.Sound();
        Console.WriteLine($"{Name} says Roar!");
    }
    public sealed override int TakeDamage(int damage)
    {
        damage = (int)(damage * 1.25); // Lion takes 25% more damage
        return base.TakeDamage(damage);
        
    }
}