using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class MenuItem
    {
        private double _price;
        private string _name;

        public MenuItem(double price, string name)
        { 
            _price = price;
            _name = name;
        }

        public double Price
        { get { return _price; } }

        public string Name
        { get { return _name; } }

    }

    

}
