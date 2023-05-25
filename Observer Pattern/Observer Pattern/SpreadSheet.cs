using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource ds;

        public SpreadSheet(DataSource ds)
        {
            this.ds = ds;
        }

        public void update()
        {
            Console.WriteLine($"SpreadSheet : Value is changed value = {ds.getValue()}");
        }
    }
}
