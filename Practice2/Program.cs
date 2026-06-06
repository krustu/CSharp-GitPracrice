using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
class Practice2
{
    private static List<Vehicle> allvehicle = new List<Vehicle>(); 
    static void Main()
    {
        Console.WriteLine("Medium Level");

        Vehicle car1 = new Car { Name = "Toyota", MaxSpeed = 120 };
        Vehicle plane1 = new Plane { Name = "Boeing", MaxSpeed = 600 };
        Vehicle boat1 = new Boat { Name = "Speedboat", MaxSpeed = 80 };

        allvehicle.Add(car1);
        allvehicle.Add(plane1);
        allvehicle.Add(boat1);

     
Console.ReadKey();
        Console.WriteLine("Using for loop");
        for (int i = 0; i < allvehicle.Count ; i++ )
        {
            Console.ReadKey();
            allvehicle[i].Move();
        }

      /*  Console.WriteLine("Using foreach loop");
Console.ReadKey();
        foreach(var a in allvehicle)
        {
            a.Move();
        } */
    }
}

class Vehicle
{

    public string? Name {get ; set;}

    
   
    public int MaxSpeed
    {
        get;
        set;
    }
    
    public virtual void Move()
    {
       Console.WriteLine($"{Name} is moving at {MaxSpeed} mph"); 
    }


}

class Car : Vehicle
{
    public override void Move()
    {
        base.Move();
       
    }

}
class Plane : Vehicle
{
    public override void Move()
    {
        base.Move();
       
    }
}
class Boat : Vehicle
{
    public override void Move()
    {
        base.Move();
       
      
    }
}