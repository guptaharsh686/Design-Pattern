using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern_Exercise
{
    public class GregorianCalender : Calendar
    {
        public void addEvent(Event event1, Date date)
        {
            Console.WriteLine("GregorianCalender : Adding an event on the given date.");
        }
    }
}
