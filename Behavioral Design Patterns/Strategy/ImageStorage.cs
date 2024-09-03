using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ImageStorage
    {
        public void store(string fileName, Compressor compressor, Filter filter) 
        {
            compressor.compress(fileName);
            filter.apply(fileName);
        }
    }
}
