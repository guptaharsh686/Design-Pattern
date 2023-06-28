using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern.Ant
{
    public class AntTextBox : ITextBox
    {
        public void render()
        {
            Console.WriteLine("Rendering Ant TextBox");
        }
    }
}
