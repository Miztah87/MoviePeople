using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestProxy.DomainModel;

namespace TestForCompulsory.Models
{
    public class ShoppingCart
    {
        public List<OrderLine> OrderLines { get; set; }
        public ShoppingCart()
        {
            OrderLines = new List<OrderLine>();
        }
        public void AddOrderLine(OrderLine line)
        {
            OrderLines.Add(line);
        }
        public void RemoveOrderLine(OrderLine line)
        {
            OrderLines.Remove(line);
        }
    }
}