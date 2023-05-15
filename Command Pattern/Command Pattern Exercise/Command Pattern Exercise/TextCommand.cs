using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Exercise
{
    public class TextCommand : IUndoableCommand
    {
        private VideoEditor videoEditor;
        private History history;
        private string prevText;

        public TextCommand(VideoEditor videoEditor, History history)
        {
            this.videoEditor = videoEditor;
            this.history = history;
        }

        public void execute()
        {
            prevText = "";
            videoEditor.setText("hello");
            history.push(this);
            
        }

        public void unExecute()
        {
            videoEditor.removeText();
        }
    }
}
