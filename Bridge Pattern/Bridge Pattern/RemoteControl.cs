using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{

    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void turnOn()
        {
            device.turnOn();
        }

        public void turnOff()
        {
            device.turnOff();
        }

    }
}
