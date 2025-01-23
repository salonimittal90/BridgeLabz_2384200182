using System;
    class Question6
    {
		public static void Main()
		{
			Question6 obj = new Question6();
			obj.CalculateTotalIncome();
		}
        public void CalculateTotalIncome()
        {
			
			// ask the user for salary and conver it into double
            Console.Write("Enter your salary (INR): ");
            double salary = Convert.ToDouble(Console.ReadLine());
            
            // Ask the user for  bonus convert it to a double
            Console.Write("Enter your bonus (INR): ");
            double bonus = Convert.ToDouble(Console.ReadLine());
            
			
            // Calculate the total income by adding salary and bonus
            double totalIncome = salary + bonus;
            
            // Display the result
            Console.WriteLine(" The salary is INR "+salary +" and bonus is INR "+bonus+". Hence, Total Income is INR "+totalIncome);
        }
    }
