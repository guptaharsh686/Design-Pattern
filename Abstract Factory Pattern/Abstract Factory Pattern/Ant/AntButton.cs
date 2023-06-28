using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern.Ant
{
    public class AntButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Rendering Ant Button");
        }
    }
}
