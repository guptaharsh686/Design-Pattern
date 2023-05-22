using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Chart : IObserver
    {

        public void update()
        {
            Console.WriteLine($"Chart : Value is changed");
        }
    }
}
