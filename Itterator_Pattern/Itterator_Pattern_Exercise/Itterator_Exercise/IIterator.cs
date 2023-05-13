using System;
using System.Collections.Generic;
using System.Text;

namespace Itterator_Exercise
{
    public interface IIterator
    {
        bool hasNext();
        Product current();
        void Next();
    }
}
