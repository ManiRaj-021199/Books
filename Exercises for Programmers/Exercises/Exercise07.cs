/*

Area of a Rectangular Room

    Create a program that calculates the area of a room. Prompt the user for the length and width of the room in feet. Then display the area in both square feet and square meters.

    Example Output
        What is the length of the room in feet? 15
        What is the width of the room in feet? 20
        You entered dimensions of 15 feet by 20 feet.
        The area is
        300 square feet
        27.871 square meters
        
    The formula for this conversion is m^2 = f^2 * 0.09290304

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

        int dimension = length * width;
        float area = (float)(dimension * 0.09290304);

        Console.WriteLine("You entered dimensions of " + length + " feet by " + width + " feet.");
        Console.WriteLine("The area is\n" + dimension + " square feet\n" + area + " square meters");
    }
}