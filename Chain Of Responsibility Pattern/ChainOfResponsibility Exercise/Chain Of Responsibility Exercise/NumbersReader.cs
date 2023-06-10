using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public class NumbersReader : DataReader
    {
        protected override void doRead(string fileName)
        {
            Console.WriteLine("Reading data from a Numbers spreadsheet: ");
        }

        protected override string getExtension()
        {
            return ".numbers";
        }
    }
}
