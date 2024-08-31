using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CompressedCloudStream : Stream
    {
        private Stream stream;

        public CompressedCloudStream(Stream stream)
        {
            this.stream = stream;   
        }

        public void write(string data)
        {
            var compressed = compress(data); 
            stream.write(compressed);
        }

        private string compress(string data) 
        {
            return data.Substring(0, 5);
        }

    }
}
