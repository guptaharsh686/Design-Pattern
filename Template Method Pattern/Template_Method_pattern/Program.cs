using System;

namespace Template_Method_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var transferMoney = new TransferMoneyTask();
            transferMoney.execute();
            //transferMoney.doExecute();
            //calling do execute directly will bypass the audit trail
            //thats why we use protected access modifier for this abstract method

            var generateReport = new GenerateReportTask();
            generateReport.execute();
        }
    }
}
