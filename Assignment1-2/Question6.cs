using System;
class Question6
{
	public static void Main()
	{
		//create object
		Question6 obj = new Question6();
		
		//call method
		obj.FinalFee();
		
	}
	public void  FinalFee()
	{
		int fee = 125000;
		int discountPercent = 10;
		
		//calculate discounted amount;
		int discount = (fee*discountPercent)/100;
		
		//calculate amount after discount
		int discountedFee = fee - discount;
		
		//display output
		Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+discountedFee);
	}
}
