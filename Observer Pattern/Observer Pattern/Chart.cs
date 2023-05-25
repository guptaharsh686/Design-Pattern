using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Chart : IObserver
    {

        public void update(int value)
        {
            Console.WriteLine($"Chart : Value is changed value = {value}");
        }
    }
}
