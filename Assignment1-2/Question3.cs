using System;
class Question3
{
	double kilometer = 10.8;
	
	public static void Main()
	{
		// create the instance of the class
		Question3 obj = new Question3();
		
		// call the ConvertDistance method
		Console.WriteLine( "The distance "+ obj.kilometer + "km in miles is "+obj.ConvertDistance());
	}
	
	public double ConvertDistance()
	{	
		// convert the kilometer to miles
		double miles = kilometer * 0.6;
		return miles;	
	}
	
}

