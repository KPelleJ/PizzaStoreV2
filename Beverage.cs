using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class Beverage : MenuItem
    {
        private string _type;
        private string _size;
        private int _number;
        private static int _numberCounter = 100;
        

        public Beverage(double price, string name, string size, string type) : base(price, name)
        {
            _number = _numberCounter++;
            _type = type;
            _size = size;
        }

        public string Type
        { get { return _type; } }

        public string Size
        { get { return _size; } }

        public int Number
        { get { return _number; } }

        
    }
}
