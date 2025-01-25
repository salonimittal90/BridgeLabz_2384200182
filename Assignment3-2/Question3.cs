using System;
class Question3
{
public static void Main()
{
	//call the method
	Table();
}
public static void Table()
{
	Console.WriteLine("Enter any number");
	int n = Convert.ToInt32(Console.ReadLine());
	int []num = new int[10];
	for(int i=0;i<num.Length;i++)
	{
		num[i] = (i+1)*n;
	}		
	for(int i=0;i<num.Length;i++)
	{
		Console.WriteLine(n+" * "+(i+1)+" = "+num[i]);

	}
	
}
}