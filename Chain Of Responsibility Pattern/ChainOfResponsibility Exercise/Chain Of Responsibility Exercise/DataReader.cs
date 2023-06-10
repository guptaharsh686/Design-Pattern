using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Exercise
{
    public abstract class DataReader
    {
        private DataReader next;

        public void setNext(DataReader next)
        {
            this.next = next;
        }

        public void read(String fileName)
        {
            if (fileName.EndsWith(getExtension()))
            {
                this.doRead(fileName);
                return;
            }

            if (next != null)
                next.read(fileName);
            else
                throw new NotSupportedException("File format not supported.");
        }

        protected abstract String getExtension();

        protected abstract void doRead(String fileName);
    }
}
