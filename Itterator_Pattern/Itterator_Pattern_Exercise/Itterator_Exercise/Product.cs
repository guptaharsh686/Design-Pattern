using System;
using System.Collections.Generic;
using System.Text;

namespace Itterator_Exercise
{
    public class Product
    {
        private int id;
        private string name;

        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Product -\n id ={id}\n name = {name} ";
        }
    }
}
