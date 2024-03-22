using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class MenuDAL
    {
        private List<MenuItem> menuItems;

        public MenuDAL() 
        { 
            menuItems = new List<MenuItem>();
            FillMenu();
        }

        public List<MenuItem> MenuItems
        { get { return menuItems; } }

        private void FillMenu()
        {
            Pizza pizza1 = new Pizza(69, "Margherita", "Tomat og ost");
            menuItems.Add(pizza1);

            Pizza pizza2 = new Pizza(76, "Vesuvio", "Tomat, ost og skinke");
            menuItems.Add(pizza2);

            Pizza pizza3 = new Pizza(80,"Capricciosa", "Tomat, ost, skinke og champignon");
            menuItems.Add(pizza3);

            Pizza pizza4 = new Pizza(80, "Calzone", "Bagt pizza med tomat, ost, skinke og champignon");
            menuItems.Add(pizza4);

            Pizza pizza5 = new Pizza(80, "Esotica", "Tomat, ost, skinke, reje og ananas");
            menuItems.Add(pizza5);

            Beverage bev1 = new Beverage(25, "Coca Cola", "50cl", "sodavand");
            menuItems.Add(bev1);

            Beverage bev2 = new Beverage(40, "Coca Cola", "1,5L", "sodavand");
            menuItems.Add(bev2);

            Beverage bev3 = new Beverage(35, "Gulddame", "33cl", "øl");
            menuItems.Add(bev3);

            Beverage bev4 = new Beverage(20, "Ramlösa citrus", "50cl", "vand");
            menuItems.Add(bev4);
        }
    }
}
