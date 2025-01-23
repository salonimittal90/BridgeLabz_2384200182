using System;
class Question11
{
	public static void Main()
	{
	Question11 obj = new Question11();
	obj.Calculator();
	
		
	}
	public void Calculator()
	{
		//take the input for num1
		Console.WriteLine("Enter the first number: ");
		float num1 = float.Parse(Console.ReadLine());
		
		// take the input for num2
		Console.WriteLine("Enter the second number: ");
		float num2 = float.Parse(Console.ReadLine());
		
		//perfrom addition operation
		float add  = num1 + num2;
		
		//perform subtraction operation
		float sub = num1- num2;
		
		//perform multiply operation
		float mul = num1* num2;
		
		
		//perform divide operation
		double div = num2!=0? num1/num2:0; 
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+num1+" and "+num2+" is "+ add+ " " +sub+" "+mul+" and "+div);
	}
}