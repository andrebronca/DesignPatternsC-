namespace DesignPatternsCSharp.CreationalPatterns;

public sealed class SingletonLazy
{
	// custom delegate
	delegate SingletonLazy SingletonDelegateWithNoParameter();
	static SingletonDelegateWithNoParameter myDel = MakeSingletonInstance;

	static Func<SingletonLazy> myFuncDelegate = MakeSingletonInstance;

	private static readonly Lazy<SingletonLazy> Instance = new
		Lazy<SingletonLazy>(
			//myDel() // also ok. or
			myFuncDelegate()    // or
								//() => new SingletonLazy(); // using lambda
			);

	private static SingletonLazy MakeSingletonInstance()
	{
		return new SingletonLazy();
	}

	private SingletonLazy() { }

	public static SingletonLazy GetInstance => Instance.Value;
}
