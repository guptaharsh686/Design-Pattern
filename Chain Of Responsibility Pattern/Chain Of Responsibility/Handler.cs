using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    public abstract class Handler
    {
        private Handler next;

        public Handler(Handler handler)
        {
            this.next = handler;
        }

        public void handle(HttpRequest httpRequest)
        {
            if (dohandle(httpRequest))
            {
                return;
            }
            if(next != null)
            {
                next.handle(httpRequest);
            }
        }


        protected abstract bool dohandle(HttpRequest httpRequest);


    }
}
