using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_pattern
{
    public class GenerateReportTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Generate Report task");
        }

    }
}
