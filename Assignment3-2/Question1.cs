using System;
class Question1
{
	public static void Main()
	{
		StudentsAge();
	}
	public static void StudentsAge()
	{
		int[]age = new int[10];
		Console.WriteLine("Enter the Age of 10 Student: ");
		for(int i=0;i<age.Length;i++)
		{
			Console.Write("Enter the age of "+(i+1)+" Student: ");
			age[i]=Convert.ToInt32(Console.ReadLine());
			if(age[i]<0)
			{
				Console.WriteLine("Invalid Age");
			}
			else if(age[i]>=18)
			{
				Console.WriteLine("The student with the age "+ age[i] +" can vote.");
			}
			else
			{
				Console.WriteLine("The student with the age "+ age[i] +" cannot vote.");
			}
		}
	}
}