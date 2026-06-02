namespace CSharp_GitPracrice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Test s1 = new Test();
        s1.Name = "John";
        s1.Age = 30;
        s1.DisplayInfo();

        Test s2 = new Test("Alice", 20);
        s2.DisplayInfo();
    }
class Test
{
    private string name;
    private int age;
    public string Name { get{ return name; } set { name = value; } } 
    public int Age { get{ return age; } set { age = value; } }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
    
}