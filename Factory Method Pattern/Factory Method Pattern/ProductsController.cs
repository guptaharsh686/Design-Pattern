using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    public class ProductsController : SharpController
    {
        public void listProducts()
        {
            //get list of products
            Dictionary<string, Object> context = new Dictionary<string, object>();
            //context.put()
            render("product.html", context);
        }
    }
}
