namespace State;

class Program
{
    static void Main(string[] args)
    {
        var canvas = new Canvas(new SelectionTool());
        canvas.mouseDown();
        canvas.mouseUp();
    }
}
