public class Authenticator : Handler
{
    public Authenticator(Handler next) : base(next)
    {
    }

    public override bool doHandle(HttpRequest request)
    {
        var isValid = (request.GetUsername() == "admin" && request.GetPassword() == "1234");

        if (isValid)
            Console.WriteLine("Authenticated");

        return !isValid;
    }
}