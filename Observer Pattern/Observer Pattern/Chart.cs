using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Chart : IObserver
    {
        private readonly DataSource ds;

        public Chart(DataSource ds)
        {
            this.ds = ds;
        }

        public void update()
        {
            Console.WriteLine($"Chart : Value is changed value = {ds.getValue()}");
        }
    }
}
