/*

Computing Simple Interest

    Create a program that computes simple interest. Prompt for the principal amount, the rate as a percentage, and the time, and display the amount accrued (principal + interest). The formula for simple interest is A = P(1 + rt) , where P is the principal amount, r is the annual rate of interest, t is the number of years the amount is invested, and A is the amount at the end of the investment.

    Example Output

        Enter the principal: 1500
        Enter the rate of interest: 4.3
        Enter the number of years: 4
        After 4 years at 4.3%, the investment will
        be worth $1758.
*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        int principal, years;
        double rate, totalAmount;

        Console.Write("Enter the principal: ");
        principal = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the rate of interest: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the number of years: ");
        years = Convert.ToInt32(Console.ReadLine());

        totalAmount = principal + (((principal * rate) / 100) * 4);

        Console.WriteLine("After " + years + " years at " + rate + "%, the investment will be worth $" + totalAmount);
    }
}