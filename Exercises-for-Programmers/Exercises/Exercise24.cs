/*

Anagram Checker

    Create a program that compares two strings and determines
    if the two strings are anagrams. The program should prompt
    for both input strings and display the output as shown in
    the example that follows.


    Example Output
        Enter two strings and I'll tell you if they are anagrams:
        Enter the first string: note
        Enter the second string: tone
        "note" and "tone" are anagrams.


*/

using System;

public class Exercise24
{
    public static void Main(string[] args)
    {
        string first, second;
        Console.WriteLine("Enter two strings and I'll tell you if they are anagrams:");

        Console.Write("Enter the first string: ");
        first = Console.ReadLine();

        Console.Write("Enter the second string: ");
        second = Console.ReadLine();

        if(IsAnagram(first, second))
        {
            Console.WriteLine($"{first} and {second} are anagrams.");
        }
        else
        {
            Console.WriteLine($"{first} and {second} are not anagrams.");
        }
    }


    public static bool IsAnagram(string first, string second)
    {
        foreach (char i in first)
        {
            if(second.IndexOf(i) == -1)
            {
                return false;
            }
        }

        return true;
    }
}