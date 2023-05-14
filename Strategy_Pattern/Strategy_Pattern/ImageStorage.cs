using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class ImageStorage
    {
        public void store(string fileName,CompressionAlgo compressor, FilterAlgo filter)
        {
            //JPEG,PNG - Image compression algo
            compressor.compress(fileName);

            filter.apply(fileName);
        }
    }
}
