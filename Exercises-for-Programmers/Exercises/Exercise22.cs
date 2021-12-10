/*

Comparing Numbers

    Write a program that asks for three numbers. Check first to
    see that all numbers are different. If they’re not different,
    then exit the program. Otherwise, display the largest number
    of the three.


    Example Output
        Enter the first number: 1
        Enter the second number: 51
        Enter the third number: 2
        The largest number is 51.

*/

using System;

public class Exercise22
{
    public static void Main(string[] args)
    {
        int max, first, second, third;

        Console.Write("Enter the first Number: ");
        first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second Number: ");
        second = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third Number: ");
        third = Convert.ToInt32(Console.ReadLine());

        if(first > second)
        {
            if(first > third)
            {
                max = first;
            }
            else
            {
                max = third;
            }
        }
        else 
        {
            if(second > third)
            {
                max = second;
            }
            else
            {
                max = third;
            }
        }

        Console.WriteLine($"The largest number is {max}.");
    }
}