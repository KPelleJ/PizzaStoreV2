using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class Pizza : MenuItem
    {
        private string _topping;
        private int _number;
        private static int _numberCounter = 1;
        
        public Pizza(double price, string name, string topping) : base(price, name)
        {
            _topping = topping;
            _number = _numberCounter++;
        }

        public string Topping
        { get { return _topping; } }

        public int Number
        { get { return _number; } }
    }
}
