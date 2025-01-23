using System;
class Question11
{
	public static void Main()
	{
		//create the object
		Question11 obj = new Question11();
		
		//call the method
		obj.SumOfNum();
		
	}
	
	public void SumOfNum()
	{
		
		double total = 0.0;
		
		
		double num ;
		while(true)
		{
			// take input untill user enter 0
			Console.Write("Enter any number (you can also press 0 to stop): ");
			num = Convert.ToDouble(Console.ReadLine());
			
			if(num<=0)
			{
				break;
			}
			total=total+num;
			
		}	
		Console.WriteLine("The sum of number until user is enter 0: "+total); 
		
	}
}