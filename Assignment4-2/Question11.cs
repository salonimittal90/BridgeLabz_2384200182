using System;
class Question11
{
	public static void Main()
	{
		//take the input from the user temperature
		Console.WriteLine(" Enter the temperature");
		double value1 = double.Parse(Console.ReadLine());
		
		//take the input from the user wind speed
		Console.WriteLine(" Enter the wind speed");
		double value2 = double.Parse(Console.ReadLine());
		
		//call the object and print the result
		Console.WriteLine("wind chill temperature for temperature "+value1+" and wind speed "+value2+ CalculateWindChill(value1, value2));
	}
	
	// create the method that return double value
	public static double CalculateWindChill(double temp, double windSpeed)
	{
		double windChill = 35.74 + 0.6215 *temp + (0.4275*temp - 35.75) * Math.Pow(windSpeed , 0.16);
		return windChill;

	}
}