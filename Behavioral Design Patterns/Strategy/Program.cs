namespace Strategy;

class Program
{
    static void Main(string[] args)
    {
        var imageStorage = new ImageStorage();

        imageStorage.store("A", new JpegCompressor(), new HighContrastFilter());
        imageStorage.store("A", new PngCompressor(), new HighContrastFilter());
    }
}
