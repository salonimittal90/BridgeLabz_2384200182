using System;
class Program
{
	public static void Main()
	{
	  Book obj = new Book("The Art of ignoring", "Saloni", 200.00);
	  obj.DisplayDetails();
	}
}

class Book
{
		private string title;
		private string author;
		private double price;
		
		public Book(string title, string author, double price)
		{
			this.title = title;
			this.author = author;
			this.price = price; 
		}
		
		public void DisplayDetails()
		{
			Console.WriteLine("The Title is: "+title);
			Console.WriteLine("The Author is: "+author);
			Console.WriteLine("The Price is: "+price);
			
		}
		
		
}

