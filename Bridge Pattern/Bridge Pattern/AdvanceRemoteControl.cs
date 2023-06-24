using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public abstract class AdvanceRemoteControl : RemoteControl
    {
        public abstract void setChannel(int channel);
    }
}
