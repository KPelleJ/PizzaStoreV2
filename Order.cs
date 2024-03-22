using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class Order
    {
        private int _id;
        private static int _idCounter = 1000;
        private double _totalPrice;
        private Customer _customer;
        private DateTime _date;
        private List<MenuItem> _itemSummary;

        public Order(List<MenuItem>itemSummary, Customer customer) 
        { 
            _itemSummary = itemSummary;
            _customer = customer;
            _date = DateTime.Now;
            _id = _idCounter++;
            _totalPrice = 0;
            
            foreach (MenuItem item in _itemSummary) 
            { 
                _totalPrice += item.Price;
            }
        }

        public int Id
        { get { return _id; } }

        public double TotalPrice 
        { get { return _totalPrice; } }

        public Customer Customer 
        { get { return _customer; } }

        public DateTime Date
        { get { return _date; } }

        public List<MenuItem> ItemSummary 
        { get {  return _itemSummary; } }



    }
}
