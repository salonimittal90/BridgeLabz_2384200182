using System;
namespace AreaOfCircle{
class Program{
	static void Main(){
	Console.WriteLine("Enter the radius of the Circle: ");
	double radius = Convert.ToDouble(Console.ReadLine());
	
	double area = Math.PI * Math.Pow(radius, 2);
	
	Console.WriteLine("The area of circle is: {0}",area);
	}
}
}
