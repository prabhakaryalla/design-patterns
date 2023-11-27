namespace design_patterns;

public sealed class SingletonWithLock
{
    private static SingletonWithLock _instance = null;
    private static readonly Object obj = new object();
    private static int instanceCount = 0;
    private SingletonWithLock()
    {
        instanceCount++;
        Console.WriteLine("Instance Count: " +  instanceCount);        
        Thread.Sleep(1000);
    }

    public static SingletonWithLock GetInstance
    {
        get
        {
            if (_instance == null)
            {
                lock(obj)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonWithLock();
                    }
                }
            }

            return _instance;
        }
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}