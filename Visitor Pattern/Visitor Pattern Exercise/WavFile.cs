using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern_Exercise
{
    public class WavFile
    {
        private List<Segment> segments = new List<Segment>();

        public static WavFile read(String fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile.segments.Add(new FormatSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());

            return wavFile;
        }

        public void reduceNoise()
        {
            foreach(var segment in segments)
                segment.execute(new ReduceNoiseFilter());
        }

        public void addReverb()
        {
            foreach(var segment in segments)
                segment.execute(new AddReverbFilter());
        }


        public void normalize()
        {
            foreach(var segment in segments)
                segment.execute(new NormalizationFilter());
        }
    }
}
