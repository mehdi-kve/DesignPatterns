 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Library
    {
        private Dictionary<string, Ebook> ebooks = new Dictionary<string, Ebook>();

        public void add(Ebook ebook) 
        {
            ebooks.Add(ebook.getFileName(), ebook);
        }

        public void openEbook(string fileName)
        {
            ebooks[fileName].show();
        }
    }
}
