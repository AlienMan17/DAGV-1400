using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What is the temperature?(In Celsius)");
		int temp = Convert.ToInt32(Console.ReadLine());
		if (temp > 30) 
		{
			Console.WriteLine("Stay hydrated and avoid staying in the sun for too long");
		}
		if (temp < 30)
		{
			Console.WriteLine("Enjoy the pleasent weather");
		}
	}
}