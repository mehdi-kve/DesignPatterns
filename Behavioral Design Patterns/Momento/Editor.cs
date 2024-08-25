using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class Editor
    {
        public string content { get; set; } = string.Empty; 

        public EditorState creatState() 
        {
            return new EditorState(content);
        }

        public void restore(EditorState state) 
        {
            content = state.getContent();
        }

    }
}
