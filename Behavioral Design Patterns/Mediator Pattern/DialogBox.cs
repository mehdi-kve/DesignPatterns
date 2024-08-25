using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    // use as IMediator
    public interface DialogBox
    {
        void changed(UIControl control);
    }
}
    