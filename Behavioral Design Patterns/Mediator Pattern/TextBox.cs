using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class TextBox : UIControl
    {
        private string content = string.Empty;

        public string getContent() 
        {
            return content;
        }
        public void setContent(string content) 
        {
            this.content = content;
            owner.changed(control: this);
        }

    }
}
