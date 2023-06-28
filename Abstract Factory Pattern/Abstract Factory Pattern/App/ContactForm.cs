using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern.App
{
    public class ContactForm
    {
        public void render(Theme theme)
        {
            //this is violating open closed principle
            // if we mistakenly assign wrong object then the code will fail
            if(theme == Theme.MATERIAL)
            {
                new Material.MaterialButton().render();
                new Material.MaterialTextBox().render();
            }
            else if(theme == Theme.ANT)
            {
                new Ant.AntButton().render();
                new Ant.AntTextBox().render();
            }

        }
    }
}
