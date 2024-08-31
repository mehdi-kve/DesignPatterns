using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealEbook : Ebook
    {
        private string fileName;

        public RealEbook(string fileName)
        {
            this.fileName = fileName;
            load();
        }

        private void load()
        {
            Console.WriteLine($"Loading the Ebook {fileName}");
        }

        public void show()
        {
            Console.WriteLine($"Showing the Ebook {fileName}");
        }

        public string getFileName()
        {
            return fileName;
        }

    }
}
