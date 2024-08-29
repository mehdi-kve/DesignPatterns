namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        var manager = ConfigManager.getInstance();
        manager.set("name", "Mosh");

        var other = ConfigManager.getInstance();
        Console.WriteLine(other.get("name"));
    }
}
