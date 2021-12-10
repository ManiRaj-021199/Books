/*

BMI Calculator:

    Create a program to calculate the body mass index (BMI)
    for a person using the person’s height in inches and weight in pounds. 
    The program should prompt the user for weight and height.
    
    Calculate the BMI by using the following formula:
        bmi = (weight / (height × height))* 703
    
    If the BMI is between 18.5 and 25, display that the person is
    at a normal weight. If they are out of that range, tell them if
    they are underweight or overweight and tell them to consult
    their doctor


    Example Output:

        Your BMI is 19.5.
        You are within the ideal weight range.
        or
        Your BMI is 32.5.
        You are overweight. You should see your doctor.

*/

using System;

public class Exercise19
{
    public static void Main(string[] args)
    {
        double weight, height;

        Console.Write("Enter your Weight in Kg: ");
        weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your Height in Cm: ");
        height = Convert.ToDouble(Console.ReadLine());

        double bmi = (weight / (height * weight)) * 703;

        if(bmi >= 18.5 && bmi <= 25)
        {
            Console.WriteLine($"Your BMI is {bmi}");
            Console.WriteLine("You are whithin the ideal weight range");
        }
        else if(bmi > 25)
        {
            Console.WriteLine($"Your BMI is {bmi}");
            Console.WriteLine("You are overweight. You should see your doctor.");
        }
        else 
        {
            Console.WriteLine($"Your BMI is {bmi}");
            Console.WriteLine("You are underweight.");
        }
    }
}