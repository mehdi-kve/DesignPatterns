namespace Proxy;

class Program
{
    static void Main(string[] args)
    {
        var lib = new Library();
        String[] fileNames = { "a", "b", "c" };
        
        foreach(var fileName in fileNames)
        {
            lib.add(new LoggingEbookProxy(fileName));
        }

        lib.openEbook("a");
    }
}
