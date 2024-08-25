using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class ListBox : UIControl
    {
        private string selection = string.Empty;

        public string getSelection() 
        {
            return selection;
        }

        public void setSelection(string selection) 
        {
            this.selection = selection;
            owner.changed(control:this);
        }


    }
}
