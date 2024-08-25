using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class UIControl
    {
        protected DialogBox owner;

        public UIControl(DialogBox owner = null)
        {
            this.owner = owner;
        }

        public void setOwner(DialogBox owner)
        {
            this.owner = owner;
        }
    }
}
