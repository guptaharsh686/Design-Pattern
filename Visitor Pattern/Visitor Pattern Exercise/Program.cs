using System;

namespace Visitor_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var wavfile = WavFile.read("file.wav");

            wavfile.addReverb();
            wavfile.normalize();
            wavfile.reduceNoise();
            
        }
    }
}
