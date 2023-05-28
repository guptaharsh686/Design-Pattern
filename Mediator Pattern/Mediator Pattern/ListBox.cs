using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class ListBox : UIControl
    {
        private string selection;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string getSelection()
        {
            return selection;
        }

        public void setSelection(string selection)
        {
            this.selection = selection;
            owner.changed(this);
        }

    }
}
