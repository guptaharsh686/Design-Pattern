using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Exercise
{
    public interface IUndoableCommand : IComand
    {
        void unExecute();
    }
}
