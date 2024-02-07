using System;

public class Program
{
    enum status
    {
        Starting,
        Running,
        Ending
    }
    
	status currentStatus = status.Ending;
    public void Main()
    {
        switch (currentStatus)
        {
            case status.Starting:
                Console.WriteLine("The game is starting");
                break;
            case status.Running:
                Console.WriteLine("The game is running");
                break;
            case status.Ending:
                Console.WriteLine("The game is ending");
                break;
        }

    }
}
