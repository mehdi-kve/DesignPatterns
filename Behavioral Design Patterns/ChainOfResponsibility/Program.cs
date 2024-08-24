namespace ChainOfResponsibility;

class Program
{
    static void Main(string[] args)
    {
        // auth -> logger -> compress -> encrypyor --> null
        var encryptor = new Encryptor(next: null);
        var compressor = new Compressor(encryptor);
        var logger = new Logger(compressor);
        var autheticator = new Authenticator(logger);
        var server = new WebServer(autheticator);
        server.Handle(new HttpRequest(usernaem:"admin", password:"1234")); 
    }
}
