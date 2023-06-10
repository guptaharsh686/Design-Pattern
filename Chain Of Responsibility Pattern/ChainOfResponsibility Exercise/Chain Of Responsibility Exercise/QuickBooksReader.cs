using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public class QuickBooksReader : DataReader
    {
        protected override void doRead(string fileName)
        {
            Console.WriteLine("Reading data from a QuickBooks file.");
        }

        protected override string getExtension()
        {
            return ".qbw";
        }
    }
}
