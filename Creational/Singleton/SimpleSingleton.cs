namespace design_patterns;

public class SimpleSingleton
{
    private static SimpleSingleton _instance = null;
    private static int instanceCount = 0;
    private SimpleSingleton()
    {
        instanceCount++;
        Console.WriteLine("Instance Count: " +  instanceCount);

    }

    public static SimpleSingleton GetInstance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new SimpleSingleton();
            }
            return _instance;
        }
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public class DerivedSimpleSingleton: SimpleSingleton
    {

    }
}