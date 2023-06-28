using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern.App
{
    public class ContactForm
    {
        public void render(WidgetFactory widgetFactory)
        {
            widgetFactory.createTextBox().render();
            widgetFactory.createButton().render(); 

        }
    }
}
