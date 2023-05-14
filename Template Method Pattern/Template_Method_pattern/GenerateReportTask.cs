using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public class GenerateReportTask
    {
        private AuditTrail auditTrail;

        public GenerateReportTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }


        public void execute()
        {
            auditTrail.record();

            Console.WriteLine("Generate report executed sucessfully");
        }
    }
}
