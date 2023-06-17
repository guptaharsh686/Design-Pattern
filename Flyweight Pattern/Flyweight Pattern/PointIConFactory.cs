using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointIConFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();
        public PointIcon getPointIcon(PointType type)
        {
            if (!icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                return icon;
            }
            icons.TryGetValue(type, out PointIcon value);
            return value;

        }
    }
}
