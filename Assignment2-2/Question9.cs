using System;
class Question9
{
	public static void Main()
	{
		//create the object
		Question9 obj = new Question9();
		
		//call the method
		obj.RocketLaunch();
		
	}
	
	public void RocketLaunch()
	{
		//take the user input for counter and convert it into the int
		Console.Write("Enter the counter: ");
		int counter = Convert.ToInt32(Console.ReadLine());
		
		//run the for loop till the value 1
		for(int i=counter; i>=1;--)
		{
			Console.WriteLine(i);
		}
		
	}
}