using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class MaterialWidgetFactory : WidgetFactory
    {
        public IButton createButton()
        {
            return new Material.MaterialButton();
        }

        public ITextBox createTextBox()
        {
            return new Material.MaterialTextBox();
        }
    }
}
