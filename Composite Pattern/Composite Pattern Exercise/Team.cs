using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern_Exercise
{
    public class Team
    {
        private List<Object> resources = new List<object>();

        public void add(Object resource)
        {
            resources.Add(resource);
        }

        public void deploy()
        {
            foreach (var resource in resources)
            {
                if (resource is Truck)
                {
                    ((Truck)resource).deploy();
                }
                else if (resource is HumanResource)
                {
                    ((HumanResource)resource).deploy();
                }
                else
                {
                    ((Team)resource).deploy();
                }
            }
        }
    }
}
