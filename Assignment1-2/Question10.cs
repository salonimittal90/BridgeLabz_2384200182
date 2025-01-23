using System;
class Question10
{
	public static void Main()
	{
		// create the object
		Question10 obj = new Question10();
		
		//call the object
		obj.ConvertHeight();
		
	}
	
	public void ConvertHeight()
	{
		// take the input of height 
		Console.Write("Enter the height into Centimeter: ");
		double heightCm = Convert.ToDouble(Console.ReadLine());
		
		// convert the height into feet
		double heightFeet = heightCm * 0.0328084;
		
		// convert the height into inches
		double heightInches = heightCm / 2.54;
		
		//display the result
		Console.WriteLine("Your Height in cm is "+heightCm+" while in feet is "+heightFeet+" nd inches is " +heightInches);
	}
}