using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern_Exercise
{
    public class Truck : ITeam
    {
        public void deploy()
        {
            Console.WriteLine("Deploying a truck");
        }
    }
}
