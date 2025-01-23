using System;
	class Question4
    {
		public static void Main()
		{
			Question4 obj = new Question4();
			obj.ConvertTemperature();
			
		}
        public void ConvertTemperature()
        {
            // Take the temperature in Celsius as input from the user
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert Celsius to Fahrenheit using the formula: (°C × 9/5) + 32 = °F
            double fahrenheitResult = (celsius * 9 / 5) + 32;

            // Display the result
		Console.WriteLine("The "+celsius+" Celsius is "+fahrenheitResult+ " Fahrenheit");
        }
    }