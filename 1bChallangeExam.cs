using System;
					
public class Program
{
	
	public void Main()
	{
		Console.WriteLine("What is your favorite subject?");
		string subject = Console.ReadLine();
		switch (subject)
		{
			case "Math":
				Console.WriteLine("Math is a useful and essential subject with many real world applications");
				break;
			case "English":
				Console.WriteLine("English is great for someone purssuing a path of literature and philosophy");
				break;
			case "Science":
				Console.WriteLine("Science is what is needed in the world to advance humanity");
				break;
			case "Art":
				Console.WriteLine("Art is perfect for people wanting to express a version of themselves to the world");
				break;
				
		}
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