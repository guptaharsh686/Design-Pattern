using System;
using System.Collections.Generic;
using System.Text;

namespace Meadiator_Using_Observer
{
    public class ListBox : UIControl
    {
        private string selection;

        public string getSelection()
        {
            return selection;
        }

        public void setSelection(string selection)
        {
            this.selection = selection;
            notify();
        }
    }
}
