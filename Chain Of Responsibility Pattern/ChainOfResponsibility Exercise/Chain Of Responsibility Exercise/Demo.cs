using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public class Demo
    {
        public static void show()
        {
            var reader = DataReaderFactory.getDataReaderChain();
            reader.read("data.xls");
            reader.read("data.numbers");
            reader.read("data.qbw");
            reader.read("data.jpg");
        }
    }
}
