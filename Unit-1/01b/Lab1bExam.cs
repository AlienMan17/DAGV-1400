using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What was your exam score?");
		int score = Convert.ToInt32(Console.ReadLine());
		if (score >= 90)
		{
			Console.WriteLine("A");
		}
		else 
		{
			if (score >= 80 && score < 90)
			{
				Console.WriteLine("B");
			}
			else
			{
				if (score >= 70 && score < 80)
				{
					Console.WriteLine("C");
				}
				else 
				{
					if (score >= 60 && score < 70)
					{
						Console.WriteLine("D");
					}
					else 
					{
						if (score <= 59)
						{
							Console.WriteLine("F");
						}
					}
				}
			}
		}
	}
}
