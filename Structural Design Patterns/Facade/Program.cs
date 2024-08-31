namespace Facade;

class Program
{
    static void Main(string[] args)
    {
        var service = new NotificationService();
        service.send("Hello, World!", "Target");
    }
}
