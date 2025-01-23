using System;
class Question4
{
	// declare variable
	int num;
	
	public static void Main()
	{
		//create object
		Question4 obj = new Question4();
		
		//take no. input from the user and convert it into double
		Console.Write("Enter the any number: ");
		obj.num = Convert.ToInt32(Console.ReadLine());
	
	
		obj.NaturalNumber();
	}
	
	// create the method to check no. is natural or not
	public void NaturalNumber()
	{
		// execute when no. is not natural
		if(num<1)
		{
			Console.WriteLine("The number "+num+" is not a natural number");

		}
		//when no is natural
		else
		{
			SumNatural();	// call the method
		}
	}
	
	// created a method to calculate the sum of natural no.
	public void SumNatural()
	{
			int res = num * (num+1)/2;
			Console.WriteLine("The sum of "+num+ " natural numbers is "+res);	
	}
}