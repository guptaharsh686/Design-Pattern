using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class FormattingAttributesFactory
    {
        private Dictionary<string,FormattingAttributes>attributes = new Dictionary<string, FormattingAttributes>();
        public FormattingAttributes GetFormattingAttributes(string type)
        {
            if (!attributes.ContainsKey(type))
            {
                var attribute = new FormattingAttributes(type, 10, true);
                attributes.Add(type, attribute);
                return attribute;

            }
            attributes.TryGetValue(type, out FormattingAttributes value);
            return value;

        }
    }
}
