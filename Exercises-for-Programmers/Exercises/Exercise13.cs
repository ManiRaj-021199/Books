/*

Determining Compound Interest

    Write a program to compute the value of an investment compounded over time. The program should ask for the starting amount, the number of years to invest, the interest rate, and the number of periods per year to compound. The formula you’ll use for this is,
    
    A = P(1 + (r / n))nt

    where,
    P is the principal amount.
    r is the annual rate of interest.
    t is the number of years the amount is invested.
    n is the number of times the interest is compounded per year.
    A is the amount at the end of the investment.


    Example Output

        What is the principal amount? 1500
        What is the rate? 4.3
        What is the number of years? 6
        What is the number of times the interest is compounded per year? 4
        $1500 invested at 4.3% for 6 years compounded 4 times per year is $1938.84.

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        int principal, years, compoundedPerYear;
        double rate, totalAmount;

        Console.Write("Enter the principal: ");
        principal = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the rate of interest: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the number of years: ");
        years = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the number of times the interest is compounded per year: ");
        compoundedPerYear = Convert.ToInt32(Console.ReadLine());  

        double tempRate = rate;
        rate = 1 + ((rate / 100) / compoundedPerYear);
        totalAmount = principal * Math.Pow(rate, (compoundedPerYear * years));

        Console.WriteLine("$" + principal + " invested at " + tempRate + "% for " + years + " years compounded " + compoundedPerYear + " times per year is $" + totalAmount);
    }
}