using System;

class Question16
{
    public void CalculateHandshakes()
    {
        //Input the number of students 
        Console.Write("Enter the number of students = ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes 
        int numberOfHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Display the result
        Console.WriteLine("The maximum number of handshakes among " +  numberOfStudents + " students is " + numberOfHandshakes);
	}

    public static void Main()
    {
        // Create an instance of the class
        Question16 obj = new Question16();
		//Calling method
        obj.CalculateHandshakes();
    }
}