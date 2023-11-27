using System.Text;

public interface Ilog
{
    void LogException(string message);
}

public sealed class Log : Ilog
{
    private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());
    private Log() { }
    public static Log GetInstance
    {
        get { return instance.Value; }
    }
    public void LogException(string message)
    {
        string filename = string.Format("{0}_{1}.log", "Exception", 
            DateTime.Now.ToShortDateString());
        string logfilePath = string.Format(@"{0}\{1}", 
            AppDomain.CurrentDomain.BaseDirectory, filename);
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("---------------------------------------------");
        sb.AppendLine(DateTime.Now.ToString());
        sb.AppendLine(message);
        using(StreamWriter writer = new StreamWriter(logfilePath, true))
        {
            writer.WriteLine(sb.ToString());
            writer.Flush();
        }
    }
}