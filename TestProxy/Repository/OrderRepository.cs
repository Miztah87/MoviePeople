using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.Context;
using TestProxy.DomainModel;

namespace TestProxy.Repository
{
   public class OrderRepository
    {
        public void Add(Order order)
        {
            using (var ctx = new ShopContextConnection())
            {
                ctx.Orders.Attach(order);
                ctx.Orders.Add(order);
                ctx.SaveChanges();
            }
        }
    }
}
