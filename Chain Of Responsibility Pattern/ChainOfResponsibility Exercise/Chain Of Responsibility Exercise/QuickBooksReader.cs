using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public class QuickBooksReader : DataReader
    {

        public QuickBooksReader(string fileName, DataReader next) : base(fileName,next)
        {
        }

        protected override bool doRead()
        {
            Console.WriteLine("Reading data from a QuickBooks file.");
            return false;

        }

        protected override string getExtension()
        {
            return ".qbw";
        }
    }
}
