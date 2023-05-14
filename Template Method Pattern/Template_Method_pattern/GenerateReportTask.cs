using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public class GenerateReportTask : Task
    {
        public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        public override void execute()
        {
            auditTrail.record();

            Console.WriteLine("Generate report executed sucessfully");
        }
    }
}
