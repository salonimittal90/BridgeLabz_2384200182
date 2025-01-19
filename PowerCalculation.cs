using System;

namespace PowerCalculation{
class Program{
static void Main(){
Console.WriteLine("Enter the Base: ");
double baseValue = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Exponent: ");
double exponent = Convert.ToDouble(Console.ReadLine());

double result = Math.Pow(baseValue, exponent);

Console.WriteLine("{0} raised to the power of {1} is: {2} ", baseValue, exponent, result);
}
}
}


