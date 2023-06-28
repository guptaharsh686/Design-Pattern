using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class AntWidgetFactory : WidgetFactory
    {
        public IButton createButton()
        {
            return new Ant.AntButton();
        }

        public ITextBox createTextBox()
        {
            return new Ant.AntTextBox();
        }
    }
}
