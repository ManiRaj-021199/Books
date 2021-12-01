/*

Paint Calculator

    Calculate gallons of paint needed to paint the ceiling of a room. Prompt for the length and width, and assume one gallon covers 350 square feet. Display the number of gallons needed to paint the ceiling as a whole number.

    Example Output
        You will need to purchase 2 gallons of paint to cover 360 square feet.
        
        Remember, you can’t buy a partial gallon of paint. You must
        round up to the next whole gallon.

*/

using System;

public class Exercise01
{
    public static void Main(string[] args)
    {
        Console.Write("What is the length of the room in feet? ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the width of the room in feet? ");
        int width = Convert.ToInt32(Console.ReadLine());

        int sqrtOfRoom = length * width;
        int gallons;

        if(sqrtOfRoom % 350 == 0) 
        {
            gallons = sqrtOfRoom / 350;
        }
        else
        {
            gallons = (sqrtOfRoom / 350) + 1;
        }

        Console.WriteLine("You will need to purchase " + gallons + " gallons of paint to cover "+ sqrtOfRoom +" square feet.");
    }
}