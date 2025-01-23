using System;

class Question13
{
    public void CalculateSide()
    {
        // Takes input from the user (perimeter of the square)
        Console.Write("Enter the perimeter of the square = ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side of the square
        double side = perimeter / 4;

        // Display the result
        Console.WriteLine("The length of the side is " + side.ToString("0.00") + " whose perimeter is " + perimeter.ToString("0.00"));
    }

    public static void Main()
    {
        //Instance of the class
        Question13 obj = new Question13();
		//Calling  the method
        obj.CalculateSide();
    }
}