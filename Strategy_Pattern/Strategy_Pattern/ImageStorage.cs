using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class ImageStorage
    {
        private string compressor;
        private string filter;

        public ImageStorage(string compressor, string filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void store(string fileName)
        {
            //JPEG,PNG - Image compression algo
            if(compressor == "jpeg")
            {
                Console.WriteLine("Compressing using JPEG");
            }
            else if(compressor == "png")
            {
                Console.WriteLine("Compressing using PNG");
            }

            if(filter == "b&w")
            {
                Console.WriteLine("Applying B&w filter");
            }
            else if(filter == "high-contrast")
            {
                Console.WriteLine("Applying high-contrast filter");
            }
        }
    }
}
