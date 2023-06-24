using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class SonyRemoteControl : RemoteControl
    {
        public override void turnOff()
        {
            Console.WriteLine("Sony Turn On");
        }

        public override void turnOn()
        {
            Console.WriteLine("Sony Turn Off");
        }
    }
}
