/*

Tax Calculator:

    Write a simple program to compute the tax on an order amount.
    The program should prompt for the order amount and the state. 
    If the state is “WI,” then the order must be charged 5.5% tax. 
    The program should display the subtotal, tax, and total for Wisconsin residents 
    but display just the total for non-residents.


    Example Output:

        What is the order amount? 10
        What is the state? WI
        The subtotal is $10.00.
        The tax is $0.55.
        The total is $10.55.
        Or
        What is the order amount? 10
        What is the state? MN
        The total is $10.00

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        double amount;
        string state;

        Console.Write("What is the order amount? ");
        amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("What is the state? ");
        state = Console.ReadLine();

        if(state == "WI")
        {
            Console.WriteLine($"The subtotal is {amount}");
            Console.WriteLine("The tax is $0.55");
            Console.WriteLine($"The total is {amount + ((amount * 5.5)/100)}");
        }
        else
        {
            Console.WriteLine($"The total is {amount}");
        }
    }
}