using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // to use generic it would be Iterator<T> 
    public interface Iterator
    {
        bool hasNext();
        string current();
        void next();
    }
}
