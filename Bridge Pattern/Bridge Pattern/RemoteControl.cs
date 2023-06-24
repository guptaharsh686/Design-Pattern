using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    //For Sony 
        //SonyRemoteControl
        //SonyAdvanceRemoteControl
    //For Samsung
        //SamsungRemoteControl
        //SamsungAdvanceRemoteControl

    public abstract class RemoteControl
    {
        public abstract void turnOn();

        public abstract void turnOff();

    }
}
