using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class DataSource : Subject
    {
        private int value;

        public int getValue()
        {
            return value;
        }

        public void setValue(int value)
        {
            this.value = value;
            notifyObserver();
        }
    }
}
