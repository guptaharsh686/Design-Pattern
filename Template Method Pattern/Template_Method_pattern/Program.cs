using System;

namespace Template_Method_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var transferMoney = new TransferMoneyTask(new AuditTrail());
            transferMoney.execute();

            var generateReport = new GenerateReportTask(new AuditTrail());
            generateReport.execute();
        }
    }
}
