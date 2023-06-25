using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern_Exercise
{
    public class ProductProxy : Product
    {
        private DbContext DbContext;
        public ProductProxy(int id, DbContext context) : base(id)
        {
            DbContext = context;
        }

        public override void setName(string name)
        {
            base.setName(name);
            DbContext.markAsChanged(this);
        }
    }
}
