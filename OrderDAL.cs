using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class OrderDAL
    {
        private List<Order> orders;

        public OrderDAL() 
        { 
            orders = new List<Order>();
        }

        public List<Order> Orders
        { get { return orders; } }
    }
}
