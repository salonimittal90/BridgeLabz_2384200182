using System;
class Question5
{
public static void Main()
{
Console.WriteLine("Enter any number");
int n = int.Parse(Console.ReadLine());

Question5 obj = new Question5();
int result = obj.CheckNumber(n);
Console.WriteLine(result);

}
	public int CheckNumber(int num)
	{
		if(num < 0)
		{
			return -1;

		}
		else if(num > 0)
		{
			return 1;
		}
		else
		{
			return 0;
		}

	}
}