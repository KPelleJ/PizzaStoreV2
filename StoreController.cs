using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class StoreController
    {
        private CustomerController customerAdmin;
        private Menu menuAdmin;
        private OrderDAL orderData;
        private Store store;

        public StoreController(string name, string address, int phonenr)
        {
            customerAdmin = new CustomerController();
            menuAdmin = new Menu();
            orderData = new OrderDAL();
            store = new Store(name, address, phonenr);
        }

        public CustomerController CustomerAdmin 
        { get { return customerAdmin; } }

        public Menu MenuAdmin 
        { get {  return menuAdmin; } }

        public OrderDAL OrderData 
        { get { return orderData; } }

        public Store Store
        { get { return store; } }

        public string ShowMenu()
        {
            string menu = "Dagens menu:\n";

            foreach (MenuItem p in menuAdmin.MenuCon.MenuData.MenuItems)
            {
                if (p is Pizza)
                {
                    menu += $"nr.{((Pizza)p).Number} {p.Name} {((Pizza)p).Topping} {p.Price}kr\n";
                }
                else
                {

                }
            }

            foreach (MenuItem b in menuAdmin.MenuCon.MenuData.MenuItems)
            {
                if (b is Beverage)
                {
                    menu += $"nr.{((Beverage)b).Number} {((Beverage)b).Type} {b.Name} {((Beverage)b).Size} {b.Price}kr\n";
                }
            }

            menu += $"\nButiks info:\n{store.Name} - {store.PhoneNr} - {store.Address}\n";
            return menu;
        }

        public string CreateOrder(List<MenuItem> list, Customer customer)
        {
            Order o = new Order(list, customer);

            string orderDetails = $"Ordre nr {o.Id}\n";
            foreach (MenuItem p in list) 
            {
                if (p is Pizza)
                {
                    orderDetails += $"nr: {((Pizza)p).Number} - {p.Name} - {((Pizza)p).Topping} - {p.Price}kr\n";
                }
                else
                {

                }
            }

            foreach (MenuItem b in list)
            {
                if (b is Beverage)
                {
                    orderDetails += $"nr.{((Beverage)b).Number} {((Beverage)b).Type} {b.Name} {((Beverage)b).Size} {b.Price}kr\n";
                }
                else
                {

                }
            }
            orderDetails += $"Totalpris = {o.TotalPrice} ({o.SalesTaxS} moms)\n";
            orderDetails += $"Kunde information:\n{customer.Name} - {customer.PhoneNr} - {customer.Address} - {customer.Email}\n";

            return orderDetails ;
        }


    }
}
