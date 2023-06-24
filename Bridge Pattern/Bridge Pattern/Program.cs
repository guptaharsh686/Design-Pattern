using System;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var remoteControl = new RemoteControl(new SonyTV());

            remoteControl.turnOn();

            var advanceRemoteControl = new AdvanceRemoteControl(new SonyTV());

            advanceRemoteControl.turnOn();
        }
    }
}
