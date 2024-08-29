using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    // Prototype Class
    public interface Component
    {
        void render();
        Component clone(); 
    }
}
