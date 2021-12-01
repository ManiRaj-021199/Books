// Class Basics

using System;

public class E01DoubleKey
{
    private string key1, key2;

    // No Args Constructor
    public E01DoubleKey()
    {
        key1 = "Key 1";
        key2 = "Key 2";
    }

    // Constructor that accepts arguments
    public E01DoubleKey(string val1, string val2)
    {
        key1 = val1;
        key2 = val2;
    }

    public static void Main(string[] args)
    {
        E01DoubleKey obj1 = new E01DoubleKey();
        E01DoubleKey obj2 = new E01DoubleKey("Mani", "Raj");
    }

    // Accessor  => Allow you to access the internal values of the object
    public string GetKey1()
    {
        return key1;
    }

    // Mutator  => Allow you to alter the internal state of the object
    public void SetKey1(string val)
    {
        key1 = val;
    }

    // Accessor
    public string GetKey2()
    {
        return key2;
    }

    // Mutator
    public void SetKey2(string val)
    {
        key2 = val;
    }
}