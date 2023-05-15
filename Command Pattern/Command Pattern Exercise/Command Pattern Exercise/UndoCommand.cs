using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Exercise
{
    public class UndoCommand : IComand
    {
        private History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void execute()
        {
            var lastComand = history.pop();
            lastComand.unExecute();
        }
    }
}
