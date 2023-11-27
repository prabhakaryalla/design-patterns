namespace design_patterns;

public sealed class SingletonWithLazyLoading
{
    private static Lazy<SingletonWithLazyLoading> _instance = new Lazy<SingletonWithLazyLoading>(new SingletonWithLazyLoading());
    private static int instanceCount = 0;
    private SingletonWithLazyLoading()
    {
        instanceCount++;
        Console.WriteLine("Instance Count: " +  instanceCount);        
        Thread.Sleep(1000);
    }

    public static SingletonWithLazyLoading GetInstance
    {
        get
        {
            return _instance.Value;
        }
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}