using Abstract_Factory.ant;
using Abstract_Factory.Interfaces;
using Abstract_Factory.material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.App
{
    public class ContactForm
    {
        /* Thats how it would be without abstract factory, no open/closed principles!
         public enum Theme
         {
            MATERIAL,
            ANT
         }
         if (theme == Theme.ANT)
         {
            new antTextBox().render();
            new antButton().render();
         }
         else if (theme == Theme.MATERIAL) 
         {
            new MaterialTextBox().render();
            new MaterialButton().render();
         }*/

        public void render(WidgetFactory factory) 
        {
            factory.createTextBox().render();
            factory.createButton().render();            
        }
    }
}
 