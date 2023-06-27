using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    public class SharpController : Controller
    {
        protected override ViewEngine GetViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}
