using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EncryptedCloudStream : Stream
    {
        private Stream stream;

        public EncryptedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            var encrypted = encrypt(data);
            stream.write(encrypted);
        }

        private string encrypt(string data) 
        {
            return "!@$%({xaakd&*dawda";
        }
    }
}
