using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Group : Component
    {
        private List<Component> components = new List<Component>();

        public void add(Component shape) 
        {
            components.Add(shape);
        }

        public void move()
        {
            foreach (Component cmp in components)
            {
                cmp.move();
            }
        }

        public void render() 
        {
            foreach (Component cmp in components) 
            {
                cmp.render();
            }
        }

    }
}
