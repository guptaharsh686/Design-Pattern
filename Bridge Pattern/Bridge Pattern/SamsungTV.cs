using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class SamsungTV : IDevice
    {
        public void setChannel(int channel)
        {
            Console.WriteLine("Samsung : Set Channel");
        }

        public void turnOff()
        {
            Console.WriteLine("Samsung : Turn Off");
        }

        public void turnOn()
        {
            Console.WriteLine("Samsung : Turn On");
        }
    }
}
