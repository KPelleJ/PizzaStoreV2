using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class Menu
    {
        private MenuController _menuCon;

        public Menu() 
        { 
            _menuCon = new MenuController();
        }

        public MenuController MenuCon
        { get { return _menuCon; } }

        

    }
}
