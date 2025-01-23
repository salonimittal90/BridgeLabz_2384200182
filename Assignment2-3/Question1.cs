using System;

class Question1 {
	public static void Main()
    {
        Console.Write("Enter a number to check if it is a prime number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine(number+" is not a prime number (Prime numbers are greater than 1).");
            return;
        }

        // Call the IsPrime method
        bool isPrime = IsPrime(number);

        // Display the result
        if (isPrime)
        {
            Console.WriteLine(number+" is a prime number.");
        }
        else
        {
            Console.WriteLine(number+" is not a prime number.");
        }
    }

    // Method to check if a number is a prime number
    static bool IsPrime(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; // Number is divisible by another number, not prime
            }
        }
        return true; // Number is prime
    }
}