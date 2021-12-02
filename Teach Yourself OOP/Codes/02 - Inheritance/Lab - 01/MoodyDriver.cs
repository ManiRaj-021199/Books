using System;

public class MoodyDriver
{
    public static void Main(string[] args)
    {
        MoodyObject moodyObject = new MoodyObject();
        HappyObject happyObject = new HappyObject();
        SadObject sadObject = new SadObject();

        Console.WriteLine("How does the moody object feels today?");
        moodyObject.QueryMood();

        Console.WriteLine("How does the happy object feels today?");
        happyObject.QueryMood();
        happyObject.Laugh();

        Console.WriteLine("How does the sad object feels today?");
        sadObject.QueryMood();
        sadObject.Cry();
    }
}


public class MoodyObject
{
    // return the mood
    protected virtual string GetMood()                  // virtual => make method overridable
    {
        return "Moody";
    }

    // ask the object how it feels
    public void QueryMood()
    {
        Console.WriteLine("I feel " + GetMood() + " today!");
    }
}


public class HappyObject : MoodyObject
{
    // redefine class mood
    protected override string GetMood()                 // override => To override existing method
    {
        return "Happy";
    }

    // specialization
    public void Laugh()
    {
        Console.WriteLine("HeHeHe...HaHaHa...");
    }
}


public class SadObject : MoodyObject
{
    // redefine class mood
    protected override string GetMood()                 // override => To override existing method
    {
        return "Sad";
    }

    // specialization
    public void Cry()
    {
        Console.WriteLine("'waaa' 'boo boo'");
    }
}