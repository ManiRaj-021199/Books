/*

Printing Quotes

    Quotation marks are often used to denote the start and end of a string. But sometimes we need to print out the quotation marks themselves by using escape characters. Create a program that prompts for a quote and an author. Display the quotation and author as shown in the example output.

    Example Output
        What is the quote? These aren't the droids you're looking for.
        Who said it? Obi-Wan Kenobi
        
        Obi-Wan Kenobi says, "These aren't the droids you're looking for."

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        Console.Write("What is the quote? ");
        string quote = Console.ReadLine();

        Console.Write("Who said it? ");
        string author = Console.ReadLine();

        Console.WriteLine(author + " says, \"" + quote + "\"");
    }
}