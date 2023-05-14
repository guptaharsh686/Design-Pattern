using Command_Pattern.Editor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class UndoCommand : ICommand
    {
        private History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void execute()
        {
            var lastCommand = history.pop();
            lastCommand.unexecute();
        }
    }
}
