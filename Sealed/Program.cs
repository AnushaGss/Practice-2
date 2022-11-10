using Microsoft.VisualBasic;
using System;
  sealed class Base
{
    public string name = "abc";
    public string city = "Banglore";
    public void GetInfo()
    {
        Console.WriteLine($"NAME: {name}");
        Console.WriteLine($"CITY: {city}");
    }
}
public class Derived : Base
{
    public int age = 23;
    public void GetAge()
    {
        Console.WriteLine($"AGE :{age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Derived d = new Derived();
        d.GetInfo();
        d.GetAge();
        Console.ReadLine();
    }

    
}

