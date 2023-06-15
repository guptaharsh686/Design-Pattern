using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Exercise
{
    public abstract class IArtifact
    {
        public string name;

        protected IArtifact(string name)
        {
            this.name = name;
        }

        public abstract string render();
    }
}
