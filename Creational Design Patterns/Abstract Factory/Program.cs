using Abstract_Factory.ant;
using Abstract_Factory.App;
using Abstract_Factory.material;

namespace Abstract_Factory;

class Program
{
    static void Main(string[] args)
    {
        new ContactForm().render(new AntWidgetFactory());
    }
}
