/*

Saying Hello

    The “Hello, World” program is the first program you learn to write in many languages, but it doesn’t involve any input. So create a program that prompts for your name and prints a greeting using your name.

    Example Output
        What is your name? Brian
        Hello, Brian, nice to meet you!

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + ", nice to meet you!");
    }
}