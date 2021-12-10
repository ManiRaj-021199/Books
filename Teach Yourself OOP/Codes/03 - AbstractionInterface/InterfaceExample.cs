using System;

public class Cars 
{
    public string TotalWheel()
    {
        return "4 wheels available";
    }
}


interface INewFeatures                              // interface contains only abstract methods
{
    string IsGpsAvailable();
}


public class Car1 : Cars, INewFeatures
{
    public string IsGpsAvailable()
    {
        return "Gps Not Available";
    }
}


public class Car2 : Cars, INewFeatures              // through an error
{                                                   // must implement inherited interface method
    /*public string IsGpsAvailable()
    {
        return "Gps Available";
    }*/
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Car1 car1 = new Car1();
        Car2 car2 = new Car2();
        
        Console.WriteLine(car1.TotalWheel());
        Console.WriteLine(car1.IsGpsAvailable());
        
        Console.WriteLine(car2.TotalWheel());
        //Console.WriteLine(car2.IsGpsAvailable());
    }
}