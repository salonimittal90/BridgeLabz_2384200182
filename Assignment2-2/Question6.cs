using System;
class Question6
{
	public static void Main()
	{
		//create object
		Question6 obj = new Question6();
		
		//call method
		obj.CheckNumber();
	}
	
	// method to check whether the no. is zero greater or smaller
	public void CheckNumber()
	{
		//take the input and convert it into the integer
		Console.Write("Enter the number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		//print if greater
		if(num>0)
		{
			Console.WriteLine("positive.");
		}
		
		//print if smaller
		else if(num<0)
		{
			Console.WriteLine("Negative.");
		}
		
		//print if zero
		else{
			Console.WriteLine("Zero");
		}
			
	}
	
}