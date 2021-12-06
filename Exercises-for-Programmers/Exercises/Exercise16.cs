/*

Legal Driving Age:

    Write a program that asks the userfortheir age and compare
    it to the legal driving age of sixteen. If the user is sixteen or
    older, then the program should display “You are old enough
    to legally drive.” If the user is under sixteen, the program
    should display “You are not old enough to legally drive.”


    Example Output:

        What is your age? 15
        You are not old enough to legally drive.
        Or
        What is your age? 35
        You are old enough to legally drive.

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        int age;

        Console.Write("What is your age? ");
        age = Convert.ToInt32(Console.ReadLine());

        if(age >= 16) 
        {
            Console.WriteLine("You are old enough to legally drive.");
        }
        else
        {
            Console.WriteLine("You are not old enough to legally drive.");
        }
    }
}