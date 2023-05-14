using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern.Editor
{
    public interface IUndoableCommand : ICommand
    {
        void unexecute();
    }
}
