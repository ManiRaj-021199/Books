/*

Blood Alcohol Calculator:

    Create a program that prompts for your weight, gender,
    number of drinks, the amount of alcohol by volume of the
    drinks consumed, and the amount of time since your last
    drink. Calculate your blood alcohol content (BAC) using this
    formula...

    BAC = (A × 5.14 / W × r) − .015 × H

    where
    • A is total alcohol consumed, in ounces (oz).
    • W is body weight in pounds.
    • r is the alcohol distribution ratio:
        – 0.73 for men
        – 0.66 for women
    • H is number of hours since the last drink.
    Display whether or not it’s legal to drive by comparing the
    blood alcohol content to 0.08.


    Example Output:

        Your BAC is 0.08
        It is not legal for you to drive.

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        double alcoholConsumed, bodyWeight, hours, bac = 0;
        string gender;

        Console.Write("How much alcohol you consumed? ");
        alcoholConsumed = Convert.ToDouble(Console.ReadLine());

        Console.Write("Body weight? ");
        bodyWeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gender? ");
        gender = Console.ReadLine();

        Console.Write("No of hours since the last drink? ");
        hours = Convert.ToDouble(Console.ReadLine());


        if(gender == "male")
        {
            bac = (alcoholConsumed * (5.14 / bodyWeight) * 0.73) - (0.015 * hours);
        }
        else if(gender == "female")
        {
            bac = (alcoholConsumed * (5.14 / bodyWeight) * 0.66) - (0.015 * hours);
        }

        if(bac >= 0.08)
        {
            Console.WriteLine("It is not legal for you to drive.");
        }
        else
        {
            Console.WriteLine("It is legal for you to drive.");
        }
    }
}