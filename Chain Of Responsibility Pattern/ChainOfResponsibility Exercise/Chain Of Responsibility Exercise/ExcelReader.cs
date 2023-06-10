using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public class ExcelReader : DataReader
    {
        protected override void doRead(string fileName)
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
        }

        protected override string getExtension()
        {
            return ".xls";
        }
    }
}
