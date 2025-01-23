using System;


class Question7
{
	public static void Main()
	{
		//create object
		Question7 obj = new Question7();
		
		//call method
		obj.VolumeOfEarth();
		
	}
	public void VolumeOfEarth()
	{
		// radius in km
		int radius = 6378;
		
		//calculate volume of earth in km
		double volumeOfSphere = (4.0/3.0) * Math.PI * Math.Pow(radius,3);
		
		//radius in miles
		double radius1 = radius*0.621371;
		
		// calculate volume of earth in miles
		double volumeOfSphere1 = (4.0/3.0)* Math.PI * Math.Pow(radius1,3);
		
		//display output
		Console.WriteLine("The volume of earth in cubic kilometers is "+ volumeOfSphere+" and cubic miles is "+ volumeOfSphere1);	
	}
}