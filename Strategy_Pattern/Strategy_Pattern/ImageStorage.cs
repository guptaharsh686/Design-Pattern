using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class ImageStorage
    {
        private CompressionAlgo compressor;
        private FilterAlgo filter;

        public ImageStorage(CompressionAlgo compressor, FilterAlgo filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void store(string fileName)
        {
            //JPEG,PNG - Image compression algo
            compressor.compress(fileName);

            filter.apply(fileName);
        }
    }
}
