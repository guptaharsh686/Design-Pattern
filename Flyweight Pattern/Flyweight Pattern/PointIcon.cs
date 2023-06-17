using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointIcon
    {

        private PointType pointType;
        private byte[] icon;

        public PointIcon(PointType pointType, byte[] icon)
        {
            this.pointType = pointType;
            this.icon = icon;
        }

        public PointType GetPointType()
        {
            return pointType;
        }
    }
}
