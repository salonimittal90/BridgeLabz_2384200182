using System;
class Question2
{
	int mathsMarks = 94;
	int physicsMarks = 95;
	int chemistryMarks = 96;
	double totalMarks = 300;
	
	public static void Main()
	{
		//create the instance of the class
		Question2 obj = new Question2();
		
		//call the AveragePercentage method
		Console.WriteLine("The average percentage of sam's marks is:" +obj.AveragePercentage()+"%");
	}
	
	//create the method
	public double AveragePercentage()
	{
		//calculate average marks
		return ((mathsMarks + physicsMarks + chemistryMarks)/totalMarks)*100;
		
	}
}
