using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class SonyAdvanceRemoteControl : AdvanceRemoteControl
    {
        public override void setChannel(int channel)
        {
            Console.WriteLine("Sony set channel");
        }

        public override void turnOff()
        {
            Console.WriteLine("Sony Turn Off");
        }

        public override void turnOn()
        {
            Console.WriteLine("Sony Turn On");
        }
    }
}
