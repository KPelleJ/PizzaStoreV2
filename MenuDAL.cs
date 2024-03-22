using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class MenuDAL
    {
        private List<Pizza> pizzas;
        private List<Beverage> beverages;
        private List<MenuItem> menuItems;

        public MenuDAL() 
        { 
            pizzas = new List<Pizza>();
            beverages = new List<Beverage>();
            menuItems = new List<MenuItem>();

        }

        public void FillMenu()
        {
           

        }
    }
}
