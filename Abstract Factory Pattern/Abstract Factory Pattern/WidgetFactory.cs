using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public interface WidgetFactory
    {
        IButton createButton();
        ITextBox createTextBox(); 
    }
}
