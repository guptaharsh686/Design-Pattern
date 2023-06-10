using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public class NumbersReader : DataReader
    {
        public NumbersReader(string filename,DataReader next) : base(filename,next)
        {
        }

        protected override bool doRead()
        {
            Console.WriteLine("Reading data from a Numbers spreadsheet: ");
            return false;

        }

        protected override string getExtension()
        {
            return ".numbers";
        }
    }
}
