using System;
    class Question1
    {
		public static void  Main()
		{
			Question1 obj = new Question1();
			obj.CalculateQuotientRemainder();
		}
        public void CalculateQuotientRemainder()
        {
            // Take two numbers as input 
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Calculate the quotient
            int quotient = number1 / number2;
			// Calculate the remainer
            int remainder = number1 % number2;

            // Display the result
            Console.WriteLine("The Quotient is"+quotient+" and Remainder is "+remainder+" of two numbers " +number1+ " and " +number2);
        }
    }

