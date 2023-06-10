using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public class DataReaderFactory
    {
        public static DataReader getDataReaderChain()
        {
            
            var quickBooksReader = new QuickBooksReader("data.qbw", null);
            var numbersReader = new NumbersReader("data.numbers", quickBooksReader);
            var excelReader = new ExcelReader("data.xls", numbersReader);

            //quickBooksReader.setNext(numbersReader);
            //numbersReader.setNext(excelReader);
            //excelReader.setNext(null);
            //quickBooksReader.setNext(null);

            return excelReader;
        }
    }
}
