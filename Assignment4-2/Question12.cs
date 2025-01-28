using System;

class TrigonometricCalculator
{
    public static void Main()
    {
        Console.WriteLine("Enter the angle in degrees:");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Create an instance of the calculator class and calculate the functions
        double[] results = calculateTrigonometricFunctions(angle);

        // Output the results
        Console.WriteLine("Sine of {angle} degrees: " + results[0]);
        Console.WriteLine("Cosine of {angle} degrees: " + results[1]);
        Console.WriteLine("Tangent of {angle} degrees: " + results[2]);
    }

    // Method to calculate various trigonometric functions
    public static double[] calculateTrigonometricFunctions(double angle)
    {
        // Convert the angle from degrees to radians
        double radians = angle * Math.PI / 180;

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the results in an array
        return new double[] { sine, cosine, tangent };
    }
}
