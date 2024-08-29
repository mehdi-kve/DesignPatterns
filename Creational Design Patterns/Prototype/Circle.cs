using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : Component
    {
        public int radius { get; set; }

        public Component clone()
        {
            Circle newCircle = new Circle();
            newCircle.radius = radius;
            return newCircle;
        }

        public void render()
        {
            Console.WriteLine($"Rendering a Circle by radius: {radius}");
        }
    }
}
