using System;

namespace SimpleInterest{
class Program{
	static void Main(){
	Console.WriteLine("Enter the Principal Amount: ");
	double principal = Convert.ToDouble(Console.ReadLine());
	
	Console.WriteLine("Enter the Rate: ");
	double rate = Convert.ToDouble(Console.ReadLine());
	
	Console.WriteLine("Enter the time: ");
	double time = Convert.ToDouble(Console.ReadLine());
	
	double interest = (principal * rate * time)/100;
	Console.WriteLine("The simple interest is: {0}", interest);
	}
}
}
	