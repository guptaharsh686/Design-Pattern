using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class SonyTV : IDevice
    {
        public void setChannel(int channel)
        {
            Console.WriteLine("Sony set channel");      
        }

        public void turnOff()
        {
            Console.WriteLine("Sony Turn Off");
        }

        public void turnOn()
        {
            Console.WriteLine("Sony Turn On");
        }
    }
}
