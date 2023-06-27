using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern_Exercise
{
    public class ArabicCalander : Calendar
    {
        public void addEvent(Event event1, Date date)
        {
            Console.WriteLine("ArabicCalander : Adding an event on the given date.");
        }
    }
}
