/*

Currency Conversion

    Write a program that converts currency. Specifically, convert euros to U.S. dollars. Prompt for the amount of money in euros you have, and prompt for the current exchange rate of the euro. Print out the new amount in U.S. dollars. The formula for currency conversion is,

    amount(to) = (amount(from) * rate(from)) / rate(to)

    where,
        - Amount to is the amount in U.S. dollars.
        - Amount from is the amount in euros.
        - rate from is the current exchange rate in euros.
        - rate to is the current exchange rate of the U.S. dollar.


    Example Output
        How many euros are you exchanging? 81
        What is the exchange rate? 137.51
        81 euros at an exchange rate of 137.51 is
        111.38 U.S. dollars.

*/

using System;

public class Exercise11
{
    public static void Main(string[] args)
    {
        int amountFrom;
        double rateFrom, rateTo = 99.63;

        Console.Write("How many euros are you exchanging? ");
        amountFrom = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the exchange rate? ");
        rateFrom = Convert.ToDouble(Console.ReadLine());

        double amountTo = (amountFrom * rateFrom) / rateTo;

        Console.WriteLine(amountFrom + " euros at an exchange rate of " + rateFrom + " is " + amountTo + " U.S Dollars");
    }
}