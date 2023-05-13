using System;
using System.Collections.Generic;
using System.Text;

namespace ItteratorPattern
{
    public interface Itterator
    {
        bool hasNext();
        string current();
        void Next();

    }
}
