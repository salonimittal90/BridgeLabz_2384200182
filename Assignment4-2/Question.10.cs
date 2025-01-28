using System;
class Question10
{
	public static void Main()
	{	
		//take the input from the user
		Console.WriteLine(" Enter the no. of chocolates");
		int numberOfchocolates = int.Parse(Console.ReadLine());
		
		//take the input from the user
		Console.WriteLine(" Enter the no. of Childern");
		int numberOfchildern = int.Parse(Console.ReadLine());
		
		int [] result = FindRemainderAndQuotient(  numberOfchocolates,  numberOfChildren)
			Console.WriteLine("number of the chocolates each student get " + eachStudentGet[0]);
			Console.WriteLine("Remaining chocolates" + remaining[1]);
		
	}
	public static  int[] FindRemainderAndQuotient(int  numberOfchocolates, int numberOfChildren)
	{
		int eachStudentGet = numberOfchocolates/numberOfChildren;
		int remaining = numberOfchocolates%numberOfChildren;
		
		return new int [] {eachStudentGet , remaining};
	}

	}