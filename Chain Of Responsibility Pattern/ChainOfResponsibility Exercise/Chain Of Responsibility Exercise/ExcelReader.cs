using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public class ExcelReader : DataReader
    {
        public ExcelReader(string filename,DataReader dataReader) : base(filename,dataReader)
        {
        }

        protected override bool doRead()
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
            return false;
        }

        protected override string getExtension()
        {
            return ".xls";
        }
    }
}
