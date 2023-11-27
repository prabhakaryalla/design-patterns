namespace design_patterns;

public sealed class SimpleSealedSingleton
{
    private static SimpleSealedSingleton _instance = null;
    private static int instanceCount = 0;
    private SimpleSealedSingleton()
    {
        instanceCount++;
        Console.WriteLine("Instance Count: " +  instanceCount);        
        Thread.Sleep(1000);
    }

    public static SimpleSealedSingleton GetInstance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new SimpleSealedSingleton();
            }
            return _instance;
        }
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}