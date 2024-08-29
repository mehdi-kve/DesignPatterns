using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Sharp
{
    public class SharpViewEngine : ViewEngine
    {
        public string render(string viewName, Dictionary<string, object> context)
        {
            return "view rendered by Sharp Engine";
        }
    }
}
