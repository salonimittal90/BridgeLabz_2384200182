using System;

class Question15
{
   public static void Main()
    {
		Question15 obj = new Question15();
        // Call the method 
        obj.ComputeFactorial();
    }

    // Method to compute the factorial
    public void ComputeFactorial()
    {
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());  // Take user input

        // Check if the entered number is a positive 
        if (n < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;  // exit no. is not positive
        }

        // Initialize factorial result to 1 
        long factorial = 1;

        // Using a for loop to compute factorial
       for (int i = 1; i <= n; i++)
        {
            factorial *= i;  // Multiply the current number with factorial
        }


        // Print the result
        Console.WriteLine("The factorial of "+n+" is: "+factorial);
    }
}
