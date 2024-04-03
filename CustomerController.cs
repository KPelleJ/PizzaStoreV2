using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStoreV2
{
    public class CustomerController
    {
        private CustomerDAL customerData;

        public CustomerController() 
        { 
            customerData = new CustomerDAL();
        }

        public CustomerDAL CustomerData
        { get { return customerData; } }

        public string CustomerList()
        {
            string list = "\nKundeliste:\n";

            foreach (Customer c in customerData.Customers)
            {
                list += $"Kunde ID: {c.Id} - Navn: {c.Name} - TLF: {c.PhoneNr} - Addresse: {c.Address} - E-mail: {c.Email} \n";
            }

            return list;
        }

        public void CreateCustomer(string name, string address, int phone, string email)
        {
            Customer cus = new Customer(name, address, phone, email);
            CustomerData.Customers.Add(cus);
        }

        public string DeleteCustomer(int id)
        {
            int count = 0;
            foreach (Customer c in CustomerData.Customers)
            {
                if (c.Id == id) 
                { 
                    count++;
                    customerData.Customers.Remove(c);
                    return $"Kunden med kunde ID: {c.Id}, {c.Name} er fjernet fra databasen";
                }
                
            }
            
            if (count == 0) 
            {
                return "Kunden findes ikke i databasen, prøv venligst igen";
            }
            
            return "";
        }

        public string UpdateCustomer(int id, string name, string address, int phone, string email)
        {
            int count = 0;
            foreach (Customer c in customerData.Customers)
            {
                if (c.Id == id)
                {
                    c.Name = name;
                    c.Address = address;
                    c.PhoneNr = phone;
                    c.Email = email;

                    return $"Kunden er blevet opdateret: ID: {c.Id} - navn: {name} - addresse: {address} - tlf: {phone} - email: {email}";
                }
                

            }

            if(count == 0)
            {
                return "Kunden findes ikke i databasen, prøv venligst igen";
            }

            return "";
        }

        public string FindCustomer(int id)
        {
            int count = 0;
            foreach(Customer c in customerData.Customers)
            { 
                if (c.Id == id)
                {
                    count++;
                    return $"Kunden fundet i databasen: ID: {c.Id} - navn: {c.Name} - addresse: {c.Address} - tlf: {c.PhoneNr} - email: {c.Email}";
                }
            }
            
            if (count == 0) 
            {
                return "Kunden findes ikke i databasen, prøv venligst igen";
            }
            
            return "";
        }
    }
}
