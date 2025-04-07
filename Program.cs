using DesignPatternsCSharp.CreationalPatterns;

public class Program
{
	public static void Main()
	{
		DemonstrationSingletonPattern();
	}

	private static void DemonstrationSingletonPattern()
	{
		Console.WriteLine("***Singleton Pattern Demonstration.***\n");
		/* The following line is used to discuss the drawback of the approach. */
		//Console.WriteLine($"The value of MyInt is: {Singleton.MyInt}");
		// Private Constructor.So, you cannot use the 'new' keyword.
		//Singleton s = new Singleton(); // error
		Console.WriteLine("Trying to get a Singleton instance, called firstInstance.");
		Singleton firstInstance = Singleton.GetInstance;
		Console.WriteLine("Trying to get another Singleton instance, called secondInstance.");
		Singleton secondInstance = Singleton.GetInstance;

		if (firstInstance.Equals(secondInstance))
		{
			Console.WriteLine("The firstIntance and secondInstance are the same.");
		}
		else
		{
			Console.WriteLine("Different instances exist.");
		}
		Console.ReadKey();
	}
}