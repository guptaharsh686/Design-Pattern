using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    public class MatchaViewEngine : ViewEngine
    {
        public string render(string viewName,Dictionary<string,Object> data)
        {
            return "View Rendered by Matcha";
        }
    }
}
