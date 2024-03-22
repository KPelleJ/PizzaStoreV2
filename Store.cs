using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class Store
    {
        private string _name;
        private string _address;
        private int _phoneNr;

        public Store(string name, string address, int phoneNr) 
        { 
            _name = name;
            _address = address;
            _phoneNr = phoneNr;
        }

        public string Name
        { get { return _name; } }

        public string Address 
        { get { return _address; } }

        public int PhoneNr 
        { get { return _phoneNr; } }
    }
}
