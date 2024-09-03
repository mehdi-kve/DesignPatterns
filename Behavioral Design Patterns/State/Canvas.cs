using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Canvas
    {
        private Tool currentTool;

        public Canvas(Tool currentTool)
        {
            this.currentTool = currentTool;
        }

        public void mouseDown()
        {
            currentTool.mouseDown();
        }

        public void mouseUp()
        {
            currentTool.mouseUp();   
        }

    }
}
