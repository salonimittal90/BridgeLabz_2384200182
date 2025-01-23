using System;

class Question13
{
   public static void Main()
    {
		Question13 obj = new Question13();
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

        // Using a while loop to compute factorial
        int i = 1;
        while (i <= n)
        {
            factorial *= i;  // Multiply the current number with factorial
            i++;  // Increment i
        }

        // Print the result
        Console.WriteLine("The factorial of "+n+" is: "+factorial);
    }
}
