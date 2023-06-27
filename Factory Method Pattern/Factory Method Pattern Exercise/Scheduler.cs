using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern_Exercise
{
    public class Scheduler
    {
        protected virtual Calendar GetCalendar()
        {
            return new GregorianCalender();
        }

        public void schedule(Event event1)
        {
            var today = new Date();
            var calendar = GetCalendar();
            calendar.addEvent(event1, today);
        }
    }
}
