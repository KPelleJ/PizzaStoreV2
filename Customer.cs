using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class Customer
    {
        private string _name;
        private string _address;
        private int _phoneNr;
        private string _email;
        private int _id;
        private static int _idCounter = 1;

        public Customer(string name, string address, int phoneNr, string email)
        { 
            _name = name;
            _address = address;
            _phoneNr = phoneNr;
            _email = email;
            _id = _idCounter++;
        }

        public string Name
        { get { return _name; } }

        public string Address
        { get { return _address; } }

        public int PhoneNr
        { get { return _phoneNr; } }

        public string Email
        { get { return _email; } }

        public int Id
        { get { return _id; } }
    }
}
