namespace design_patterns;

public sealed class SingletonWithEagerLoading
{
    private static SingletonWithEagerLoading _instance = new SingletonWithEagerLoading();
    private static int instanceCount = 0;
    private SingletonWithEagerLoading()
    {
        instanceCount++;
        Console.WriteLine("Instance Count: " +  instanceCount);        
        Thread.Sleep(1000);
    }

    public static SingletonWithEagerLoading GetInstance
    {
        get
        {
            return _instance;
        }
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}