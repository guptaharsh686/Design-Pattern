using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern.Editor
{
    public class History
    {
        private List<IUndoableCommand> commands = new List<IUndoableCommand>();
        
        public void push(IUndoableCommand command)
        {
            commands.Add(command);
        }
    
        public IUndoableCommand pop()
        {
            var lastCommand = commands[commands.Count - 1];
            commands.Remove(lastCommand);
            return lastCommand;
        }
    
    
    }
}
