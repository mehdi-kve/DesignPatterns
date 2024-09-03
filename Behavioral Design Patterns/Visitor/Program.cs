namespace Visitor;

class Program
{
    static void Main(string[] args)
    {
        var document = new HtmlDocument();
        document.add(new HeadingNode());
        document.add(new AnchorNode());
        document.execute(new PlaintextVisitor());
    }
}
