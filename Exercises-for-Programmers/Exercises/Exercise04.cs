/*

Mad Lib

    Mad libs are a simple game where you create a story template with blanks for words. You, or another player, then construct a list of words and place them into the story, creating an often silly or funny story as a result. Create a simple mad-lib program that prompts for a noun, a verb, an adverb, and an adjective and injects those into a story that you create.

    Example Output
        Enter a noun: dog
        Enter a verb: walk
        Enter an adjective: blue
        Enter an adverb: quickly
        Do you walk your blue dog quickly? That's hilarious!

*/

using System;

public class Exercise04
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a noun: ");
        string noun = Console.ReadLine();

        Console.Write("Enter a verb: ");
        string verb = Console.ReadLine();

        Console.Write("Enter a adjective: ");
        string adjective = Console.ReadLine();

        Console.Write("Enter a adverb: ");
        string adverb = Console.ReadLine();

        Console.WriteLine("Do you " + verb + " your " + adjective + " " + noun + " " + adverb + " That's hilarious!");
    }
}