/*

Simple Math

    You’ll often write programs that deal with numbers. And depending on the programming language you use, you’ll have to convert the inputs you get to numerical data types. Write a program that prompts for two numbers. Print the sum, difference, product, and quotient of those numbers as shown in the example output:

    Example Output
        What is the first number? 10
        What is the second number? 5
        10 + 5 = 15
        10 - 5 = 5
        10 * 5 = 50
        10 / 5 = 2


*/

using System;

public class Exercise05
{
    public static void Main(string[] args)
    {
        Console.Write("What is the first number? ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the second number? ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
        Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
        Console.WriteLine(firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
        Console.WriteLine(firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
    }
}