using System;
class Question10
{
	public static void Main()
	{	
		//take the input from the user
		Console.WriteLine(" Enter the no. of chocolates");
		int numberOfChocolates = int.Parse(Console.ReadLine());
		
		//take the input from the user
		Console.WriteLine(" Enter the no. of Childern");
		int numberOfChildern = int.Parse(Console.ReadLine());
		
		// call the function and store the result 
		int [] result = FindRemainderAndQuotient(numberOfChocolates,  numberOfChildern);
		
			//print the result 
			Console.WriteLine("number of the chocolates each student get " + result[0]);
			Console.WriteLine("Remaining chocolates" + result[1]);
		
	}
	// create the method that return the array
	public static  int[] FindRemainderAndQuotient(int  number, int divisor)
	{
		int eachStudentGet = number/divisor;
		int remaining = number%divisor;
		
		return new int [] {eachStudentGet , remaining};
	}

	}