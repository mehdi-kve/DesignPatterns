using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.material
{
    public class MaterialWidgetFactory : WidgetFactory
    {
        public Button createButton()
        {
            return new MaterialButton();
        }

        public TextBox createTextBox()
        {
            return new MaterialTextBox();
        }
    }
}
