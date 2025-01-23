using System;
class Question1
{
	public static void Main()
	{
		// create object
		Question1 obj = new Question1();
		
		//call the method
		obj.Divisibilty();
		
	}
	
	//create the method to Divisibilty
	public void Divisibilty()
	{
		// take the number fron user 
		Console.WriteLine("Enter any number");
		
		
		//convert it into double
		double n = Convert.ToDouble(Console.ReadLine());
		
		//perform modulus operation
		double res = n%5;
		
		// check if the remainder is 0 then print yes
		if(res==0){
			Console.WriteLine("Is the number "+n+" divisible by 5? Yes");
		}
		
		// if remainder is not 0 then print no
		else 
		{
		Console.WriteLine("Is the number "+n+"divisible by 5? No");
		}
	}
}