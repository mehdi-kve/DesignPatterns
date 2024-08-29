using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PdfDocument
    {
        public void addPage(string text) 
        {
            Console.WriteLine(text);
        }
    }
}
