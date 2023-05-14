using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class Button
    {
        private string label;
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public string Label { get => label; set => label = value; }

        public void click()
        {
            command.execute();   
        }
    }
}
