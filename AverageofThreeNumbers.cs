using System;

namespace AverageOfThreeNumbers{
class Program{
static void Main(){
Console.WriteLine("Enter the First Number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Second Number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Third Number: ");
double num3 = Convert.ToDouble(Console.ReadLine());

double avg = (num1 + num2 + num3)/3;
Console.WriteLine("The Average of Three Number is:{0}", avg);
}
}
}