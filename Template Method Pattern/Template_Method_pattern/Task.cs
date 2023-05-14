using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public abstract class Task
    {
        protected AuditTrail auditTrail;

        public Task()
        {
            auditTrail = new AuditTrail();
        }

        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void execute()
        {
            auditTrail.record();

            doExecute();
        }

        //declaring this public will cause audit trail bypass
        //declaring this private will cause this method to not get inherited
        //declaring protected will cause it to get inherited as well as be private in inherited sub class 
        protected abstract void doExecute();
    }
}
