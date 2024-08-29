using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.QB
{
    public class Controller
    {
        public void render(string viewName, Dictionary<string, object> context)
        {
            var engine = createViewEngine();
            var html = engine.render(viewName, context);
            Console.WriteLine(html);
        }

        protected virtual ViewEngine createViewEngine()
        {
            return new QBViewEngine();
        }
    }
}
