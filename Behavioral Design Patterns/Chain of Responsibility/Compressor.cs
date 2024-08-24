public class Compressor : Handler
{
    public Compressor(Handler next) : base(next)
    {
    }

    public override bool doHandle(HttpRequest request)
    {
        Console.WriteLine("Compressed");
        return false;
    }
}