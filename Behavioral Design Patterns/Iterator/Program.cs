namespace IteratorPattern;

class Program
{
    static void Main(string[] args)
    {
        var history = new BrowseHistory();
        history.push(url:"https://www.google.com");
        history.push(url: "https://www.microsoft.com");
        history.push(url: "https://www.bing.com");

        var iterator = history.CreateIterator();
        while(iterator.hasNext())
        {
            var url = iterator.current();
            Console.WriteLine(url);
            iterator.next();
        }

    }
}
