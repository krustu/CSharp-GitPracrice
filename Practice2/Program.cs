using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
class Practice2
{
    private static List<Vehicle> allvehicle = new List<Vehicle>(); 
    static void Main()
    {
        Console.WriteLine("Meduim Level");
        allvehicle.Add(new Car());
        allvehicle.Add(new Plane());
        allvehicle.Add(new Boat());

        Vehicle transp = new Vehicle();
        
        for (int i = 0; i < allvehicle.Count ; i++ )
        {
            allvehicle[i].Move();
        }
    }
}

class Vehicle
{
    public string Name
    {
         get;
        set;
    }
    public int MaxSpeed
    {
        get;
        set;
    }
    
    public virtual void Move()
    {
        
    }


}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is driving");
    }

}
class Plane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Plane is flying");
        
    }
}
class Boat : Vehicle
{
    public override void Move()
    {
       // base.Move();
       Console.WriteLine("boat is floating");
    }
}