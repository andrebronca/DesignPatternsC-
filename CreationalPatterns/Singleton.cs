namespace DesignPatternsCSharp.CreationalPatterns;

public sealed class Singleton
{
	#region Singleton implementation using static constructor

	private static readonly Singleton Instance;
	private static int TotalInstances;

	/*
	 * Private constructior is used to prevent creation of instances with the 'new' keyword outside this class.
	 */
	private Singleton()
	{
		Console.WriteLine("--Private constructor is called.");
		Console.WriteLine("--Exit now from private constructor.");
	}

	/*
	 * A static constructor is used for the following purposes:
	 * 1. To initialize any static data
	 * 2. To perform a specific action only once
	 * 
	 * The static constructor will be called automatically before:
	 * i. You create the first instance; or
	 * ii. You refer to any static members in your code.
	 */

	static Singleton()
	{
		Console.WriteLine("-Static constructor is called.");
		Instance = new Singleton();
		TotalInstances++;
		Console.WriteLine($"-Singleton instance is created. Number of instances:{TotalInstances}");
		Console.WriteLine("-Exit from static constructor.");
	}

	public static Singleton GetInstance => Instance;
	#endregion

	/* The following line is used to discuss the drawback of the approach. */
	public static int MyInt = 25;
}
