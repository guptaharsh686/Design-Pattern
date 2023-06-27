using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern_Exercise
{
    public class ArabicScheduler : Scheduler
    {
        protected override Calendar GetCalendar()
        {
            return new ArabicCalander();
        }
    }
}
