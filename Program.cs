using System.Threading.Channels;

namespace PizzaStoreV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //MenuController m = new MenuController();
            //Menu mm = new Menu();
            //
            //foreach (MenuItem p in mm.MenuCon.MenuData.MenuItems)
            //{
            //    if (p is Pizza)
            //    {
            //        Console.WriteLine($"nr.{((Pizza)p).Number} {p.Name} {((Pizza)p).Topping} {p.Price}kr");
            //    }
            //    else
            //    {
            //
            //    }
            //}
            //foreach (MenuItem p in mm.MenuCon.MenuData.MenuItems)
            //{
            //    if (p is Beverage)
            //    {
            //        Console.WriteLine($"nr.{((Beverage)p).Number} {((Beverage)p).Type} {p.Name} {((Beverage)p).Size} {p.Price}kr ");
            //    }
            //}
            //Console.WriteLine(" ");
            //
            //mm.MenuCon.CreatePizza(20, "pepperoni", "Tomat, ost og pepperoni");
            //mm.MenuCon.CreateBeverage(89, "IKFK", "50cl", "sodavand");
            //
            //
            //try
            //{
            //    mm.MenuCon.CreateBeverage(20, "IKFK", "50cl", "sodavand");
            //}
            //catch (NameAlreadyExistException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(" ");
            //}
            //
            //try
            //{
            //    mm.MenuCon.CreatePizza(20, "pepperoni", "Tomat, ost og pepperoni");
            //}
            //catch (NameAlreadyExistException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(" ");
            //}
            //
            //CustomerController c1 = new CustomerController();
            //
            //c1.CreateCustomer("Arne","Tulipanvej 11",31502633,"arne@email.com");
            //c1.CreateCustomer("Bent","Plantagevej 48",84928474,"bent@email.com");
            //c1.CreateCustomer("Charlotte", "Storegade 2", 93837262, "char@mail.com");
            //
            //Console.WriteLine(c1.CustomerList());
            //
            //Console.WriteLine(c1.DeleteCustomer(3));
            //
            //Console.WriteLine(c1.CustomerList());
            //
            //Console.WriteLine(c1.UpdateCustomer(3,"Knud","Gade 1",36272633,"knud@email.com"));
            //
            //Console.WriteLine(c1.CustomerList());
            //
            //Console.WriteLine(c1.FindCustomer(2));
            //
            //Console.WriteLine(c1.FindCustomer(5));

            StoreController s = new StoreController("Big Mammas","Roskildevej 22",77885511);

            Console.WriteLine(s.ShowMenu());

            s.CustomerAdmin.CreateCustomer("Anna","plavej 12",22883377,"anna@email.com");
            s.CustomerAdmin.CreateCustomer("Bent", "Golfvej 7", 87636268, "bent@email.com");
            List<MenuItem> o1 = new List<MenuItem>();
            o1.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[0]);
            o1.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[3]);
            o1.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[4]);
            o1.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[7]);

            List<MenuItem> o2 = new List<MenuItem>();
            o2.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[1]);
            o2.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[2]);
            o2.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[3]);
            o2.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[8]);
            o2.Add(s.MenuAdmin.MenuCon.MenuData.MenuItems[6]);



            Console.WriteLine(s.CreateOrder(o1, s.CustomerAdmin.CustomerData.Customers[0]));
            Console.WriteLine(s.CreateOrder(o2, s.CustomerAdmin.CustomerData.Customers[1]));

            Console.WriteLine(s.CustomerAdmin.CustomerList());
        }

        
    }
}
