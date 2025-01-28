using System;
class Question8
{
	public static void Main()
	{
		Console.WriteLine("Enter the first number");
		int num1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the second number");
		int num2 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the third number");
		int num3 = int.Parse(Console.ReadLine());
		
		
		int[] result = FindSmallestAndLargest( num1,  num2,  num3);
		Console.WriteLine("	The smallest number is " + result[0]);
		Console.WriteLine("	The largest number is " + result[1]);
	}
	public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
	
	{
		// check for largest
		int largest = ((number1>number2)? (number1 > number3) ? number1 : number3 :( number2 > number3)? number2 : number3);
		
		
		//check for smallest
		int smallest = ((number1<number2)? (number1 < number3) ? number1 : number3 :( number2 < number3)? number2 : number3);
			
		return new int[] { smallest, largest }; 
		
	}
}