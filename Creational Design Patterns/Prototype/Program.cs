namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle();
        circle.radius = 13;
        circle.render();

        var context = new ContextMenu();

        var newCircle = context.duplicate(circle);
        newCircle.render();
    }
}
