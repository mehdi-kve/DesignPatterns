namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        var group1 = new Group();
        group1.add(new Shape("Circle"));
        group1.add(new Shape("Circle"));

        var group2 = new Group();
        group2.add(new Shape("Triangle"));
        group2.add(new Shape("Triangle"));

        var group = new Group();
        group.add(group1);
        group.add(group2);
        group.render();
        group.move();
    }
}
