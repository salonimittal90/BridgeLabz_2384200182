using System;
    class Question3
    {
		public static void Main()
		{
			Question3 obj = new Question3();
			obj.PerformOperations();
			
		}
        public void PerformOperations()
        {
            // Take the input from user 
            Console.Write("Enter the first number (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number (c): ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Perform the operations
            double result1 = a + b * c;       
            double result2 = a * b + c;       
            double result3 = c + a / b;       
            double result4 = a % b + c;       

            // Display the output
            Console.WriteLine("The results of Double Operations are: ");
            Console.WriteLine("a + b * c = "+result1);
            Console.WriteLine("a * b + c "+result2);
            Console.WriteLine("c + a / b "+result3);
            Console.WriteLine("a % b + c "+result4);
        }
    }
