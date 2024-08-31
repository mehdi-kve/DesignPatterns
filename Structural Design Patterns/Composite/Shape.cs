using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Shape : Component
    {
        private string type = string.Empty;

        public Shape(string shapeType)
        {
            this.type = shapeType;    
        }

        public void move()
        {
            Console.WriteLine($"Move Shape : {type}");
        }

        public void render() 
        {
            Console.WriteLine($"Render Shape: {type}");
        }
    }
}
