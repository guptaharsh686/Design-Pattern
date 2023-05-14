using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public class AuditTrail
    {
        public void record()
        {
            Console.WriteLine("Audit");
        }
    }
}
