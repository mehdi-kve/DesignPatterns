public class Encryptor : Handler
{
    public Encryptor(Handler next) : base(next)
    {
    }

    public override bool doHandle(HttpRequest request)
    {
        Console.WriteLine("Encrypted");
        return false;
    }
}