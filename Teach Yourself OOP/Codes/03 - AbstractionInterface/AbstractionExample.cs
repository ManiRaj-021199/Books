using System;

public abstract class Cars                              // abstract contains both normal and abstract method
{                                                       // need to be used when both methods are wanted
    public string TotalWheel()
    {
        return "4 wheels available";
    }
    
    public abstract string CheckAc();
}


public class Car1 : Cars
{
    public override string CheckAc()
    {
        return "Ac Not Available";
    }
}


public class Car2 : Cars
{
    public override string CheckAc()
    {
        return "Ac Available";
    }
}


public class AbstractionExample
{
    public static void Main(string[] args)
    {
        Car1 car1 = new Car1();
        Car2 car2 = new Car2();
        
        Console.WriteLine(car1.TotalWheel());
        Console.WriteLine(car1.CheckAc());
        
        Console.WriteLine(car2.TotalWheel());
        Console.WriteLine(car2.CheckAc());
    }
}