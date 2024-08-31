using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class EbookProxy : Ebook
    {
        private string fileName;
        private RealEbook ebook;

        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string getFileName()
        {
            return fileName;
        }

        public void show()
        {
            if (ebook == null) 
            {
                ebook = new RealEbook(fileName);
            }
            ebook.show();
        }
    }
}
