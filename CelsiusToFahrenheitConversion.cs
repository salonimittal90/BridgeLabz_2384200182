using System;
namespace CelsiusToFahrenheitConversion{
class Program{
	static void Main(){
	Console.WriteLine("Enter the temperature into Celsius: ");
	double celsius = Convert.ToDouble(Console.ReadLine());
	
	double fahrenheit = (celsius * 9/5)+32;
	Console.WriteLine("{0}C is equal to {1}F", celsius, fahrenheit);
	}
}
}