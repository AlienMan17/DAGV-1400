using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What is the temperature?(In Celsius)");
		int temp = Convert.ToInt32(Console.ReadLine());
		if (temp <= 10) 
		{
			Console.WriteLine("Consider wearing multiple layers");
		}
		if (temp > 10 && temp <=20)
		{
			Console.WriteLine("You might be well off with a jacket");
		}
		if (temp >= 30 && temp <= 35) 
		{
			Console.WriteLine("There is pleasent weather today");
		}
		if (temp > 35)
		{
			Console.WriteLine("Dress lightly for the hot weather");
		}
	}
}
