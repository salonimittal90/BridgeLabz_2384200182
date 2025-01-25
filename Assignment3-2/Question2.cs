using System;
class Question2
{
	public static void Main()
	{
		
		Console.WriteLine("Enter the 5 numbers");
		
		//declare an array of size 5
		int[] num = new int[5];
		
		// run the loop
		for(int i=0;i<num.Length;i++)
		{
			// take the input and convert into int
			Console.Write("Enter the "+ (i+1)+" number: ");
			num[i] = Convert.ToInt32(Console.ReadLine());
			
			//call the method
			CheckNumber(num[i]);
		
		}
		
		//call the method
		CompareNumber(num);
	}
	
	//method check whether the entered no. is positive negative or zero
	public static void CheckNumber(int num)
	{
			//no. is positive
			if(num>0)
			{
				if(num%2==0)
				{
				Console.WriteLine("The "+num+" is positive and it is even");
				}
				else
				{
					Console.WriteLine("The "+num+" is positive and it is odd");
				}
			}
			//no. is negative
			else if(num <0)
			{
				Console.WriteLine("The "+num+" is negative");
			}
			
			//number is zero
			else
			{
				Console.WriteLine("The number is Zero");
			}
	}
	public static void CompareNumber(int[] num)
	{
		if(num[0] == num[num.Length-1])
		{
			Console.WriteLine("The first element "+num[0]+" and the last element "+num[num.Length-1]+" of  the array is equal");
		}
		else if(num[0] > num[num.Length-1])
		{
			Console.WriteLine("The first element "+num[0]+" is greater than the last element "+num[num.Length-1]+" of the array ");
		}
		else
		{
			Console.WriteLine("The first element "+num[0]+" is smaller than the last element "+num[num.Length-1]+" of the array ");
		}
	}
}