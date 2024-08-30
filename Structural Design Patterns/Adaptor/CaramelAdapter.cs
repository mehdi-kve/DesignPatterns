using Adaptor.ThirdPartyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    public class CaramelAdapter : Filter
    {
        private CaramelFilter caramelFilter;

        public CaramelAdapter(CaramelFilter filter)
        {
            this.caramelFilter = filter;
        }

        public void apply(Image image)
        {
            caramelFilter.init();
            caramelFilter.render(image);
        }
    }
}
