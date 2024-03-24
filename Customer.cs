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
        { get { return _name; } set { _name = value; } }

        public string Address
        { get { return _address; } set { _address = value; } }

        public int PhoneNr
        { get { return _phoneNr; } set { _phoneNr = value; } }

        public string Email
        { get { return _email; } set { _email = value; } }

        public int Id
        { get { return _id; } }
    }
}
