using System;

namespace VolumeOfCylinder{
	class Program{
 static void Main(){
 Console.WriteLine("Enter the radius: ");
 double radius = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Enter the height: ");
 double height = Convert.ToDouble(Console.ReadLine());
 
 double volume = Math.PI * Math.Pow(radius, 2) *height;
 
 Console.WriteLine("The volume of a Cylinder is:{0} ", volume);
 }
}
}
