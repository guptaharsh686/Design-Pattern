using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Exercise
{
    public class ContrastCommand : IUndoableCommand
    {
        private History history;
        private VideoEditor videoEditor;
        private float prevContrast;

        public ContrastCommand(History history, VideoEditor videoEditor)
        {
            this.history = history;
            this.videoEditor = videoEditor;
        }

        public void execute()
        {
            prevContrast = videoEditor.getContrast();
            videoEditor.setContrast(10);
            history.push(this);
        }

        public void unExecute()
        {
            videoEditor.setContrast(prevContrast);
        }
    }
}
