using System;
class Program
{
	public static void Main()
	{
		Circle obj = new Circle(2.0);
		obj.DisplayDetails();
		
	}
}
class Circle
{

	private double radius;
	
	public Circle(double radius)
	{
		this.radius = radius;
	}
	public double AreaOfCircle()
	{
		double result = Math.PI*radius*radius;
		
		return result;
	}
	
	public double CircumferenceOfCicle()
	{
		double result1 = 2* Math.PI*radius;
		
		return result1;
	}
	public void DisplayDetails()
	{
		Console.WriteLine("Radius of Circle: " +radius);
		Console.WriteLine("Area of Circle: " +AreaOfCircle());
		Console.WriteLine("Circumfrence of Circle: " +CircumferenceOfCicle());
		
		
	}
}