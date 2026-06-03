using System;
using System.Runtime.InteropServices;
class Practice1
{
    static void Main()
    {
        //Animal animal = new Animal();
        //animal.Speak();
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal bird = new Bird();
        cat.Speak();
        bird.Speak();
        dog.Speak();
        
        
    }
}
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("animal sound");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        //base.Speak();
        Console.WriteLine("mew mew");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        //base.Speak();
        Console.WriteLine("Gav Gav");
    }
}
class Bird : Animal
{
    public override void Speak()
    {

        Console.WriteLine("tik tik");
    }
}