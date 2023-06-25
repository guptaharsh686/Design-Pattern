using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern
{
    public interface IComponent
    {
        void render();
        IComponent clone();
    }
}
