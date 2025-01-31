using System;

namespace Question4
{
    class DateCompare
    {
        static void Main()
        {
            // Prompt user for the first date
            Console.Write("Enter the first date (yyyy-MM-dd): ");
            string input1 = Console.ReadLine();
            
            // Prompt user for the second date
            Console.Write("Enter the second date (yyyy-MM-dd): ");
            string input2 = Console.ReadLine();

            // Try parsing the input strings to DateTime (fixed syntax)
            DateTime date1, date2;
            bool isValidDate1 = DateTime.TryParse(input1, out date1);
            bool isValidDate2 = DateTime.TryParse(input2, out date2);

            if (isValidDate1 && isValidDate2)
            {
                // Using DateTime.Compare()
                int result = DateTime.Compare(date1, date2);

                // Display comparison result with proper formatting
                Console.WriteLine("\nComparison Result:");
                Console.WriteLine("First Date  : " + date1.ToString("yyyy-MM-dd"));
                Console.WriteLine("Second Date : " + date2.ToString("yyyy-MM-dd"));

                if (result < 0)
                    Console.WriteLine("=> The first date is before the second date.");
                else if (result > 0)
                    Console.WriteLine("=> The first date is after the second date.");
                else
                    Console.WriteLine("=> Both dates are the same.");
            }
            else
            {
                Console.WriteLine("Invalid date format! Please enter dates in yyyy-MM-dd format.");
            }

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
