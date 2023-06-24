using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class AdvanceRemoteControl  : RemoteControl
    {

        public AdvanceRemoteControl(IDevice device) : base(device)
        {

        }
        public void setChannel(int channel)
        {
            device.setChannel(1);
        }
    }
}
