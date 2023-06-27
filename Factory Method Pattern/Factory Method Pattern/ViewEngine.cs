using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    public interface ViewEngine
    {
        string render(string viewNAme, Dictionary<string, Object> context);
    }
}
