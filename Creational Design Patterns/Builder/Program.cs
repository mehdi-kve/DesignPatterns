namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        var presentation = new Presentation();
        presentation.addSlide(new Slide(text:"slide 1"));
        presentation.addSlide(new Slide(text:"slide 2"));

        var builder = new MovieBuilder();
        presentation.export(builder);
        var movie = builder.getMovie();
    }
}
