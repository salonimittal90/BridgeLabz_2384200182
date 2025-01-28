using System;
    class Question1
    {
		public static void Main()
		{
			Question1 obj = new Question1();
			obj.CalculateSimpleInterest();
		}
        public void CalculateSimpleInterest()
        {
            // Take input values for principal, rate, and time
            Console.Write("Enter the Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the Time period (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());
            
            // Calculate Simple Interest
            double simpleInterest = (principal * rate * time) / 100;
            
            // Display the result
            Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time);
        }
    }

