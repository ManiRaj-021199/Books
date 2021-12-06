/*

Temperature Converter:

    Create a program that converts temperatures from Fahrenheit to Celsius or from Celsius to Fahrenheit. 
    Prompt for the starting temperature. The program should prompt for the type of conversion 
    and then perform the conversion.

    The formulas are
        C = (F − 32) × 5 / 9
    and
        F = (C × 9 / 5) + 32


    Example Output:

        Press C to convert from Fahrenheit to Celsius.
        Press F to convert from Celsius to Fahrenheit.
        Your choice: C
        Please enter the temperature in Fahrenheit: 32
        The temperature in Celsius is 0.

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        char userChoice;

        Console.WriteLine("Press C to convert from Fahrenheit to Celsius.");
        Console.WriteLine("Press F to convert from Celsius to Fahrenheit.");

        Console.Write("Your choice: ");
        userChoice = Convert.ToChar(Console.ReadLine());

        if(userChoice == 'C')
        {
            Console.Write("Please enter the temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The temperature in Celsius is {(fahrenheit - 32) * (5 / 9)}.");
        }
        else if(userChoice == 'F')
        {
            Console.Write("Please enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The temperature in Fahrenheit is {(celsius * (9 / 5)) + 32}.");
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }
}