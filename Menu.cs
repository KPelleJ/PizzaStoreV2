using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class Menu
    {
        private MenuDAL _menuData;

        public Menu() 
        { 
            _menuData = new MenuDAL();
        }

        public MenuDAL MenuData 
        { get { return _menuData; } }

        

    }
}
