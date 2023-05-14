using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public class TransferMoneyTask : Task
    {

        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {

        }

        public override void execute()
        {
            auditTrail.record();

            Console.WriteLine("Transfer Money Sucessful..");
        }
    }
}
