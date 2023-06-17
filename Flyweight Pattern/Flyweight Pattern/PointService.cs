using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointService
    {
        PointIConFactory factory;

        public PointService(PointIConFactory factory)
        {
            this.factory = factory;
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, factory.getPointIcon(PointType.CAFE));
            points.Add(point);
            return points;
        }
    }
}
