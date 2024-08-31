namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        storeCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));
    }

    public static void storeCreditCard(Stream stream)
    {
        stream.write(data: "1234-1234-1234-1234");
    }
}
