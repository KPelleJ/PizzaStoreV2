using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class CustomerDAL
    {
        private List<Customer> customers;

        public CustomerDAL() 
        {
            customers = new List<Customer>();
        }

        public List<Customer> Customers
        { get { return customers; } }
    }
}
