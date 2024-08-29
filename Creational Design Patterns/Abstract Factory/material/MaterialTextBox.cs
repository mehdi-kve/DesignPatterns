using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.material
{
    public class MaterialTextBox : TextBox
    {
        public void render()
        {
            Console.WriteLine("Material Textbox");
        }
    }
}
