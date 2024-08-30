using Adaptor.ThirdPartyLib;

namespace Adaptor;

class Program
{
    static void Main(string[] args)
    {
        var imageView = new ImageView(new Image());
        var caramelFilter = new CaramelAdapter(new CaramelFilter());
        imageView.apply(caramelFilter);
    }
}
