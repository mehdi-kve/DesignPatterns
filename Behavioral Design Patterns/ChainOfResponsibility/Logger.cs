public class Logger : Handler
{
    public Logger(Handler next) : base(next)
    {
    }

    public override bool doHandle(HttpRequest request)
    {
        Console.WriteLine("Logged in");
        return false;
    }
}