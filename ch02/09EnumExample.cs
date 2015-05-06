using System;
class EnumExample
{
	public enum TimeOfDay
	{
		Morning = 0,
		Afternoon = 1,
		Evening = 2
	}
	
	public static int Main()
	{
		WriteGreeting(TimeOfDay.Morning);
		return 0;
	}
	
	static void WriteGreeting(TimeOfDay timeOfDay)
	{
		switch(timeOfDay)
		{
			case TimeOfDay.Morning:
				Console.WriteLine("Good morning!");
				break;
			case TimeOfDay.Afternoon:
				Console.WriteLine("Good afternoon!");
				break;
			case TimeOfDay.Evening:
				Console.WriteLine("Good evening!");
				break;				
		}
	}
}