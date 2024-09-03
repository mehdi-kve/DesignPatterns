﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class BrushTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
