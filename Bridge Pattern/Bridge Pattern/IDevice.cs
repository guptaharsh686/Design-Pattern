using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public interface IDevice
    {
        void turnOn();
        void turnOff();
        void setChannel(int channel);
    }
}
