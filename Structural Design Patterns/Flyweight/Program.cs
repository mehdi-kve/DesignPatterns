namespace Flyweight;

class Program
{
    static void Main(string[] args)
    {
        var service = new PointService(new PointIconFactory());

        foreach (Point point in service.getPoints()) 
        {
            point.draw();
        }
    }
}
