using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("How large should the pyramid be");
		var size = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 1; i <= size; i++)
		{
			for (int j = 1; j <= i; j++)
			{
				Console.Write(i);
			}
			Console.WriteLine("");
		}
		
	}
}
