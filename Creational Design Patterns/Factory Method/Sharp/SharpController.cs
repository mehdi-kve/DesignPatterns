using Factory_Method.QB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Sharp
{
    public class SharpController : Controller
    {
        protected override ViewEngine createViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}
