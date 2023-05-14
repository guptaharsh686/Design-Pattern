using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public class TransferMoneyTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Transfer money");
        }
    }
}
