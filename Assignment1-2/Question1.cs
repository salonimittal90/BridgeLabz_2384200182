using System;
class Question1
{
	int birthYear = 2000; 		
	int currentYear = 2024;		
	public static void Main()
	{
		// create an instance of the class
		Question1 obj = new Question1();
		
		//call the CalculateAge method 
		Console.WriteLine("Harry's age in 2024 is "+ obj.CalculateAge());
	}
	
	// Create Method
	public int CalculateAge()
	{ 
		//calculate and return age
		return currentYear-birthYear;
	}	
}
