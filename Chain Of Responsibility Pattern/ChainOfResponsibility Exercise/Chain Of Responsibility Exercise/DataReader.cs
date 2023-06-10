using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public abstract class DataReader
    {
        private DataReader next;
        private string filename;

        protected DataReader(string filename,DataReader next)
        {
            this.next = next;
            this.filename = filename;
        }

        public void read()
        {
            if (filename.EndsWith(getExtension()))
            {
                if(this.doRead())
                    return;
            }

            if (next != null)
                next.read();
            else
                throw new NotSupportedException("File format not supported.");
        }

        protected abstract String getExtension();

        protected abstract bool doRead();
    }
}
