using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern_Exercise
{
    public class Demo
    {
        public static void show()
        {
            var scheduler = new Scheduler();
            var arabicScheduler = new ArabicScheduler();
            scheduler.schedule(new Event());
            arabicScheduler.schedule(new Event());
        }
    }
}
