using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern_Exercise
{
    public interface IComponent
    {
        IComponent clone();
    }
}
