using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class MenuController
    {
        private MenuDAL menuData;
        
        public MenuController() 
        { 
            menuData = new MenuDAL();
        }

        public MenuDAL MenuData
        { get { return menuData; } }

        //Metode til at lave pizza
        public void CreatePizza(double price, string name, string topping )
        {
            int count = 0;
            foreach (MenuItem item in menuData.MenuItems)
            {
                if (item.Name == name)
                {
                    count++;
                }
                else
                { }
            }

            if (count > 0)
            {
                throw new NameAlreadyExistException("Navnet findes allerede på menuen, prøv venligst et andet navn");
            }
            else
            {
                MenuItem pizza = new Pizza(price, name, topping);
                menuData.MenuItems.Add(pizza);
            }
        }

        //Metode til at lave en drikkevare
        public void CreateBeverage(double price, string name, string size, string type)
        {
            int count = 0;
            foreach ( MenuItem item in menuData.MenuItems ) 
            { 
                if ( item.Name == name ) 
                {
                    count++;
                }
                else
                { }
            }

            if (count > 0)
            {
                throw new NameAlreadyExistException("Navnet findes allerede på menuen, prøv venligst et andet navn");
            }
            else
            {
                MenuItem bev = new Beverage(price, name, size, type);
                menuData.MenuItems.Add(bev);
            }
        }

        //Metode til at fjerne en genstand fra menuen
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

        
        //Metode til at opdatere prisen på en genstand på menuen
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

        //Metode til at finde en genstand på menuen
        public string FindMenuItem(int number)
        {
            
            foreach (MenuItem item in menuData.MenuItems)
            { 
                if (item is Pizza && ((Pizza)item).Number == number)
                {
                    return $"nr. {((Pizza)item).Number} {item.Name} {((Pizza)item).Topping} {item.Price}kr";
                }
                else if (item is Beverage &&  ((Beverage)item).Number == number) 
                {
                    return $"nr. {((Beverage)item).Number} {((Beverage)item).Type} {item.Name} {((Beverage)item).Size} {item.Price}kr";
                }
                else 
                {
                    return "Der er ikke noget på menuen med dette nummer";
                }
            }
            return "";
        }


    }
}
