/*

Counting the number of characters

    Create a program that prompts for an input string and displays output that shows the input string and the number of characters the string contains.
    
    Example Output
        What is the input string? Homer
        Homer has 5 characters.

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        Console.Write("What is the input string? ");
        string text = Console.ReadLine();
        Console.WriteLine(text + " has " + text.Length + " characters.");
    }
}