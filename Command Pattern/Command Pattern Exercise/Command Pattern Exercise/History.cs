using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Exercise
{

    public class History
    {
        private List<IUndoableCommand> history = new List<IUndoableCommand>();

        public void push(IUndoableCommand command)
        {
            history.Add(command);
        }

        public IUndoableCommand pop()
        {
            var lastCommand = history[history.Count - 1];
            history.Remove(lastCommand);
            return lastCommand;
        }

    }
}
