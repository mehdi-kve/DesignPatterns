using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.QB
{
    internal class QBViewEngine : ViewEngine
    {
        public string render(string viewName, Dictionary<string, object> context)
        {
            return "View Rendered by QBEngine";
        }
    }
}
