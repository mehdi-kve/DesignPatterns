using IteratorPattern;

public class BrowseHistory 
{
    private List<string> urls = new List<string>();
    
    public void push(string url) 
    {
        urls.Add(url);
    }

    public string pop() 
    {
        var lasIndex = urls.Count - 1;
        var lastUrl = urls[lasIndex];
        urls.Remove(lastUrl);

        return lastUrl;
    }

    public Iterator CreateIterator()
    {
        return new ListIterator(history: this);     
    }

    public class ListIterator : Iterator
    {
        private BrowseHistory history;
        private int index;

        public ListIterator(BrowseHistory history)
        {
            this.history = history;
        }

        public string current()
        {
            return history.urls[index];
        }

        public bool hasNext()
        {
            return (index < history.urls.Count);
        }

        public void next()
        {
            index++;
        }
    }
}