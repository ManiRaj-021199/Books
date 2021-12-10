/*

Numbers to Names:

    Write a program that converts a number from 1 to 12 to the
    corresponding month. Prompt for a number and display the
    corresponding calendar month, with 1 being January and
    12 being December. For any value outside thatrange, display
    an appropriate error message.


    Example Output
        Please enter the number of the month: 3
        The name of the month is March.

*/

using System;

public class Exercise21
{
    public static void Main(string[] args)
    {
        string[] monthNames = {"Jan", "Feb", "March", "April", "May", "June", "July", "Auguest", "September", "October", "November", "December"};

        Console.Write("Please enter the number of the month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The name of the month is {monthNames[month - 1]}.");
    }
}