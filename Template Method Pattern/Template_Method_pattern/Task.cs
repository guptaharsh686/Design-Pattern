using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public abstract class Task
    {
        protected AuditTrail auditTrail;

        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public abstract void execute();
    }
}
