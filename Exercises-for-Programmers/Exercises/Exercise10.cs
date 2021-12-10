/*

Self Checkout

    Create a simple self-checkout system. Prompt for the prices and quantities of three items. Calculate the subtotal of the items. Then calculate the tax using a tax rate of 5.5%. Print out the line items with the quantity and total, and then print out the subtotal, tax amount, and total.

    Example Output

        Enter the price of item 1: 25
        Enter the quantity of item 1: 2
        Enter the price of item 2: 10
        Enter the quantity of item 2: 1
        Enter the price of item 3: 4
        Enter the quantity of item 3: 1
        Subtotal: $64.00
        Tax: $3.52
        Total: $67.52

*/

using System;

public class Exercise10
{
    public static void Main(string[] args)
    {
        int item1Price, item2Price, item3Price, item1Quantity, item2Quantity, item3Quantity, subTotal;
        double tax, total;
        
        Console.Write("Enter the price of item 1: ");
        item1Price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the quantity of item 1: ");
        item1Quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the price of item 2: ");
        item2Price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the quantity of item 2: ");
        item2Quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the price of item 3: ");
        item3Price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the quantity of item 3: ");
        item3Quantity = Convert.ToInt32(Console.ReadLine());

        subTotal = (item1Price * item1Quantity) + (item2Price * item2Quantity) + (item3Price * item3Quantity);
        tax = (subTotal * 5.5) / 100;
        total = subTotal + tax;

        Console.WriteLine("Subtotal: $" + subTotal);
        Console.WriteLine("Tax: $" + tax);
        Console.WriteLine("Total: $" + total);
    }
}