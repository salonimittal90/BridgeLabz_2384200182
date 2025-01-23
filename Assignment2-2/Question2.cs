using System;
class Question2
{
	public static void Main()
	{
		Question2 obj = new Question2();
		obj.SmallestNumber();
		
	}
	public void SmallestNumber()
	{
		// Take all three numbers and convert it into double
		Console.WriteLine("Enter the first number");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the second number");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the third number");
		int num3 = Convert.ToInt32(Console.ReadLine());
		
		//check whether the first is small or not
		if(num1 < num2 && num1 < num3)
		{
			Console.WriteLine("Is the first number the smallest? Yes");

		}
		else{
			Console.WriteLine("Is the first number the smallest? No");
		}
	}
}