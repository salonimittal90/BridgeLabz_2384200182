using System;
class Question5
{
	public static void Main()
	{
		//create the instance
		Question5 obj = new Question5();
		
		//call the method
		obj.DistributedPens();	
	}
	public void DistributedPens()
	{
		int totalPens = 14;
		int students =3;
		
		// calculate pens divide among students
		int distributedPens = totalPens/students;
		
		// calculate remaining pens 
		int remainingPens = totalPens%students;
		
		// display the output
		Console.WriteLine("The Pen Per Student is " +distributedPens+ " and the remaining pen not distributed is "+remainingPens);	
	}
}