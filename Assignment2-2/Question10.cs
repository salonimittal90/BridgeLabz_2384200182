using System;
class Question10
{
	public static void Main()
	{
		Question10 obj = new Question10();
		obj.SumOfNumbers();
		
	}
	public void SumOfNumbers()
	{
		double total = 0.0;
		
		Console.Write("Enter any number: ");
		double num ;
		do
		{
			Console.Write("Enter any number (you can also press 0 to stop)");
			num = Convert.ToDouble(Console.ReadLine());
			total+= num;
			
		}while(num!=0);
			
		Console.WriteLine("The sum of number until user is enter 0 "+total); 
				
		
	}
}