using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class SpreadSheet : IObserver
    {
        public void update()
        {
            Console.WriteLine($"SpreadSheet : Value is changed");
        }
    }
}
