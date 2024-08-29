using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.ant
{
    public class AntTextBox : TextBox
    {
        public void render()
        {
            Console.WriteLine("Ant Textbox");
        }
    }
}
