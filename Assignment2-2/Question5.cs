using System;
class Question5
{
	public static void Main()
	{
		//create the object
		Question5 obj = new Question5();
		
		//call the method.
		obj.EligibleToVote();
	}
	
	//create the method to check whether the person is eligible to vote
	public void EligibleToVote()
	{
		//take the input and convert into int
		Console.Write("Enter your age: ");
		int age = Convert.ToInt32(Console.ReadLine());
		
		//if age is greater then 18 or equal.
		if(age>=18)
		{
			Console.WriteLine("The person's age is "+age+" and can vote. ");
		}
		//if age is not greater then 18.
		else
		{
		Console.WriteLine("The person's age is "+age+" and cannot vote. ");
	
		}
		
	}
	
}