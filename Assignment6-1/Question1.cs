using System;
namespace Question1
{
class Program
{
		//create a main Method
		public static void Main()
		{
			//create the object
			EmployeeDetails obj = new EmployeeDetails("saloni",101,100000.0);
			//call the object
			obj.DisplayDetails();
		}

}

	//create employee class 
	class EmployeeDetails
	{
		
		//define attributes
		private string name;
		private int id ;
		private double salary;
		
		//create the parameterized constructor
		public EmployeeDetails(string name, int id, double salary)
		{
			//initialize the value of attributes
			this.name = name;
			this.id = id;
			this.salary = salary;
			
		}
		
		// details the details
		public void DisplayDetails()
		{
			Console.WriteLine("Employee Name: "+name);
			Console.WriteLine("Employee id: "+id);
			Console.WriteLine("Employee Salary: "+salary);
			
		}
			
	}
}

