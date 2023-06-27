using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    public class Controller
    {
        public void render(string viewName,Dictionary<string,Object> context)
        {
            var engine = GetViewEngine();
            //tight coupling to view engine users cannot use thier own engine
            var html = engine.render(viewName, context);
            Console.WriteLine(html);
        }

        protected ViewEngine GetViewEngine()
        {
            return new MatchaViewEngine();
        }

        //also can be implemented using abstract class
        //protected abstract ViewEngine getViewEngine()

    }
}
