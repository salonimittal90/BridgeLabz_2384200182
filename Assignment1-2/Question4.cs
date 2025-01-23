using System;
class Question4
{
	int costPrice = 129;
	int sellingPrice = 191;
	
	public static void Main()
	{
		// create the object
		Question4 obj = new Question4();
		
		//call the method
		obj.CalculateProfit();
	}
	public void CalculateProfit()
	{
		//calculate profit 
		int profit = sellingPrice - costPrice;
		
		// calculate the profit percentage
		double profitPercentage = (profit/(double)costPrice)*100;
		
		//display the result
		Console.WriteLine("The Cost Price is INR " + costPrice +"and Selling Price is INR "+sellingPrice+"\n The Profit is INR "+ profit +" and the Profit Percentage is "+ profitPercentage);
	}
}
