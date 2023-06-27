using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    class SharpViewEngine : ViewEngine
    {
        public string render(string viewNAme, Dictionary<string, object> context)
        {
            return "View rendered by sharp";
        }
    }
}
