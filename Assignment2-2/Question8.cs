using System;
class Question8
{
	public static void Main()
	{
		//create the object
		Question8 obj = new Question8();
		
		//call the method
		obj.RocketLaunch();
		
	}
	
	public void RocketLaunch()
	{
		//take the user input and convert it into the integer 
		Console.Write("Enter the counter: ");
		int counter = Convert.ToInt32(Console.ReadLine());
		
		//run till the value 1
		while(counter!=0)
		{
			//print the value of counter everytime
			Console.WriteLine(counter); 
			counter--;					//decrease the counter
		}
		
	}
}