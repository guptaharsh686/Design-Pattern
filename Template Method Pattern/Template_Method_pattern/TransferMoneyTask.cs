using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public class TransferMoneyTask
    {
        private AuditTrail auditTrail;

        public TransferMoneyTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void execute()
        {
            auditTrail.record();

            Console.WriteLine("Transfer Money Sucessful..");
        }
    }
}
