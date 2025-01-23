using System;
class Question3
{
	public static void Main()
	{
		//create object
		Question3 obj = new Question3();
		
		//call the method
		obj.SmallestNumber();
		
	}
	public void SmallestNumber()
	{
		// Take all three numbers and convert it into double
		Console.Write("Enter the first number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the second number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the third number: ");
		int num3 = Convert.ToInt32(Console.ReadLine());
		
		//check whether the first is large or not and print the result
		if(num1 > num2 && num1 > num3)
		{
			Console.WriteLine("Is the first number the largest?  Yes");
			Console.WriteLine("Is the second number the largest? No");
			Console.WriteLine("Is the third number the largest?  No");
		}
		
		//check whether the second is large or not and print the result
		else if(num2>num1 && num2>num3){
			Console.WriteLine("Is the first number the largest?  No");
			Console.WriteLine("Is the second number the largest? Yes");
			Console.WriteLine("Is the third number the largest?  No");

			
		}
		//check whether the second is large or not and print the result
		else if(num3>num1 && num3>num2){
			Console.WriteLine("Is the first number the largest?  No");
			Console.WriteLine("Is the second number the largest? No");
			Console.WriteLine("Is the third number the largest?  yes");
			
		}
		else{
			Console.WriteLine("Is the first number the largest?  No");
			Console.WriteLine("Is the second number the largest? No");
			Console.WriteLine("Is the third number the largest?  No");
		}
	}
}