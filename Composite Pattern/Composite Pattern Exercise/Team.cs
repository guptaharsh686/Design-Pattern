using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern_Exercise
{
    public class Team : ITeam
    {
        private List<ITeam> resources = new List<ITeam>();

        public void add(ITeam resource)
        {
            resources.Add(resource);
        }

        public void deploy()
        {
            foreach (var resource in resources)
            {
                resource.deploy();
            }
        }
    }
}
