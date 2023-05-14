using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern.Editor
{
    public class BoldCommand : IUndoableCommand
    {
        private string prevContent;
        private HTMLDocument document;
        private History history;

        public BoldCommand(HTMLDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void execute()
        {
            prevContent = document.getContent();
            document.makeBold();
            history.push(this);
        }

        public void unexecute()
        {
            document.setContent(prevContent);
        }
    }
}
