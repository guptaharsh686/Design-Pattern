using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern.Material
{
    public class MaterialTextBox : ITextBox
    {
        public void render()
        {
            Console.WriteLine("Rendering Material TextBox");
        }
    }
}
