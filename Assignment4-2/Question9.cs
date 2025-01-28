using System;
class Question9
{
public static void Main()
{
	Console.WriteLine("Enter the number ");
	int number = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter the Divisor ");
	int divisor = int.Parse(Console.ReadLine());
	
	
	int[] result = FindRemainderAndQuotient(number,  divisor);
	Console.WriteLine("Quotient" + result[0]);
	Console.WriteLine("Remainder" + result[1]);
	
}
public static int[] FindRemainderAndQuotient(int number, int divisor) 
{
	
	int quotient = number / divisor;
	int remaider = number % divisor;
	
	return new int [] {quotient , remaider};
}
}