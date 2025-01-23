using System;
class Question8
{
	public static void Main()
	{
		//create object
		Question8 obj = new Question8();
		
		//call method
		obj.KilometerToMiles();
		
		
	}
	public void KilometerToMiles()
	{
		//take the input im miles
		Console.Write("Enter the Distance in Kilometer: ");
		double km = Convert.ToDouble(Console.ReadLine());
		
		//convert it into miles
		double miles = km/1.6;
		
		//display the output
		Console.WriteLine("The total miles is "+miles +" mile for the given "+km+" km");
	}
}	