using System;
class Question1
{
	public static void Main()
	{
		int[] heights = new int [11];
		Random random = new Random();

		for(int i=0;i<heights.Length;i++)
		{
			heights[i] = random.Next(150,251);
		}
		Array.Sort(heights);
		
		int sum = SumOfElements(heights);
		double meanHeight = MeanHeight(sum , heights.Length);
		int shortestHeight = ShortestHeight(heights);
		int tallestHeight= TallestHeight(heights);
		
		
		Console.WriteLine("Sum of all the elements in the array "+sum);
		Console.WriteLine("Mean height of the players on the football team "+meanHeight);
		Console.WriteLine("Shortest height of the players on the football team "+shortestHeight);
		Console.WriteLine("Tallest height of the players on the football team "+tallestHeight);
		
	}
	public static int SumOfElements(int [] heights)
	{
			int sum =0;
			for(int i=0;i<heights.Length;i++)
			{
				 sum=sum+heights[i];
			}
		return sum;
	}
	
	public static double MeanHeight( int sum , int length)
	{
			double meanHeight = (double)sum/length;
			return meanHeight;
	}
	
	public static int ShortestHeight(int []heights)
	{
		
		int shortestHeight = heights[0];
		return shortestHeight;
	}
	
	public static int TallestHeight(int []heights)
	{
		
		int tallestHeight = heights[heights.Length-1]; 
		return tallestHeight;
	}
}