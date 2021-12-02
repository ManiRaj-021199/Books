/*

Retirement Calculator

    Your computer knows what the current yearis, which means you can incorporate that into your programs. You just have to figure out how your programming language can provide you with that information. Create a program that determines how many years you have left until retirement and the year you can retire. It should prompt for your current age and the age you want to retire and display the output as shown in the example that follows.

    Example Output
        What is your current age? 25
        At what age would you like to retire? 65
        You have 40 years left until you can retire.
        It's 2015, so you can retire in 2055.

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        int currentYear = DateTime.Now.Year;

        Console.Write("What is your current age? ");
        int currentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("At what age would you like to retire? ");
        int retireAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You have " + (retireAge - currentAge) + " years left untill you can retire.");
        Console.WriteLine("It's " + currentYear + ", so you can retire in " + (currentYear + (retireAge - currentAge)) + ".");
    }
}