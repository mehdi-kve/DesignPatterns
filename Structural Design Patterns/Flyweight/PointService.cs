using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class PointService
    {
        private PointIconFactory iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> getPoints() 
        {
            var points = new List<Point>();
            var point = new Point(x:1, y:4, iconFactory.getPointIcon(PointType.CAFE));
            points.Add(point);
            return points;
        }
    }
}
