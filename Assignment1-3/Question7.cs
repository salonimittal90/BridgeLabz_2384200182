using System;
class Question7
    {
		public static void Main()
		{
			Question7 obj = new Question7();
			obj.SwapNumbers();
		}
		
        public void SwapNumbers()
        {
            // take the input for first number
            Console.Write("Enter the first number: ");
            
            //convert to int
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            // take the  input for second number
            Console.Write("Enter the second number: ");
            
            //convert to int
            int number2 = Convert.ToInt32(Console.ReadLine());
            
            // Display the numbers before swapping
            Console.WriteLine("\nBefore Swapping: Number1 = "+number1+", Number2 = "+number2);
            
            // Swap the values of number1 and number2 using a temporary variable
            int temp = number1;
            number1 = number2;
            number2 = temp;
            
            // Display the numbers after swapping
            Console.WriteLine("After Swapping: Number1 = "+number1+", Number2 = "+number2);
        }
    }
