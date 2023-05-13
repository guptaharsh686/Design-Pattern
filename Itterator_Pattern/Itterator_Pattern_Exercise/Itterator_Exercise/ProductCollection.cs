using System;
using System.Collections.Generic;
using System.Text;

namespace Itterator_Exercise
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public void add(Product product)
        {
            products.Add(product);
        }

        public IIterator createIterator()
        {
            return new ProductList(this);
        }

        public class ProductList : IIterator
        {
            ProductCollection pc;
            int index;
            public ProductList(ProductCollection pc)
            {
                this.pc = pc;
            }
            public Product current()
            {
                return pc.products[index];
            }

            public bool hasNext()
            {
                return (index < pc.products.Count);
            }

            public void Next()
            {
                index++;
            }
        }

    }
}
