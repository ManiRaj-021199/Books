/*

Password Validation:

    Create a simple program that validates userlogin credentials.
    The program must prompt the user for a username and password. 
    The program should compare the password given by the user to 
    a known password. If the password matches, the program should 
    display “Welcome!” If it doesn’t match, the program should 
    display “I don’t know you.”


    Output:

        What is the password? 12345
        I don't know you.
        Or
        What is the password? abc$123
        Welcome!

*/

using System;

public class Exercise15
{
    public static void Main(string[] args)
    {
        string correctPassword = "abc$123", password;

        Console.Write("What is the password? ");
        password = Console.ReadLine();

        if(password == correctPassword)
        {
            Console.WriteLine("Welcome!");
        }
        else
        {
            Console.WriteLine("I don't know you.");
        }
    }
}