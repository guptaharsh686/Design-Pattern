using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class AttributesFactory
    {
        private Dictionary<int, Attributes> keyValues = new Dictionary<int, Attributes>();
        public Attributes GetAttributes(string fontFamily ,int fontSize = 12 ,bool isBold = false)
        {
            var obj = new Attributes(fontFamily, fontSize, isBold);
            var hash = obj.hashCode;
            Console.WriteLine($"Hash = {hash}");
            if (!keyValues.ContainsKey(hash))
            {
                keyValues.Add(hash, obj);
                Console.WriteLine("Returning new Object");
                return obj;
            }
            Console.WriteLine("Returning old Object");
            return obj;

        }
    }
}
