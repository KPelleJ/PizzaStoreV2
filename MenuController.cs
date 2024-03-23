using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    internal class MenuController
    {
        private MenuDAL menuData;
        
        public MenuController() 
        { 
            menuData = new MenuDAL();
        }

        public MenuDAL MenuData
        { get { return menuData; } }

        public void CreatePizza(double price, string name, string topping )
        {
            MenuItem pizza = new Pizza(price, name, topping);
            menuData.MenuItems.Add(pizza);
        }

        public void CreateBeverage(double price, string name, string size, string type)
        {
            MenuItem bev = new Beverage(price, name, size, type);
            menuData.MenuItems.Add(bev);
        }

        public string DeleteMenuItem(string menuItem)
        {
            int count = 0;
            foreach (MenuItem item in menuData.MenuItems) 
            {
                if (item.Name == menuItem)
                {
                    menuData.MenuItems.Remove(item);
                    count--;
                    break;

                }
                else
                {
                    count++;
                }
            }

            if (count == menuData.MenuItems.Count) 
            {
                return $"{menuItem} kunne ikke findes på menuen, prøv venligst igen";
            }
            else 
            {
                return $"{menuItem} er nu blevet fjernet fra menuen";
            }

        }

        public string UpdateMenuItem(string name,int price)
        {
            int count = 0;
            foreach (MenuItem item in menuData.MenuItems)
            { 
                if (item.Name == name) 
                { 
                    item.Price = price;
                    count--;
                    break;
                } 
                else 
                { 
                    count++; 
                }
            }

            if (count == menuData.MenuItems.Count)
            {
                return $"Kunne ikke finde {name} på menuen, prøv venligst igen";
            }
            else
            {
                return $"Prisen på {name} er blev opdateret til {price} i menuen";
            }
        }


    }
}
