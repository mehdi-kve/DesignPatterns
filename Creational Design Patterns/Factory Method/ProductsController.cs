using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method.QB;
using Factory_Method.Sharp;

namespace Factory_Method
{
    public class ProductsController : SharpController
    {
        public void listProducts()
        {
            // Get Products from DB
            Dictionary<string, object> context = new Dictionary<string, object>();
            // context.put(products)
            render(viewName: "products.html", context);
        }
    }
}
