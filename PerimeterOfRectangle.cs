using System;

namespace PerimeterOfRectangle{
class Program{
static void Main(){
Console.WriteLine("Enter the Length: ");
double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Width: ");
double width = Convert.ToDouble(Console.ReadLine());

double perimeter = 2 *(length*width);
Console.WriteLine("The Perimeter of a Rectangle is:{0} ", perimeter);
}
}
}