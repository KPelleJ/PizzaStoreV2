namespace PizzaStoreV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is my pizza store app

            //MenuItem pizza1 = new Pizza(69, "Margherita", "Tomat og ost");
            //Pizza pizza2 = new Pizza(76, "Vesuvio", "Tomat, ost og skinke");
            //
            //MenuItem bev1 = new Beverage(25, "Coca Cola", "50cl", "sodavand");
            //MenuItem bev2 = new Beverage(40, "Coca Cola", "1,5L", "sodavand");
            //
            //Customer cus1 = new Customer("Ole","Plantagevej 11", 31502633, "mail@mail.com");
            //Console.WriteLine();
            //
            //
            //
            //List<MenuItem> list = new List<MenuItem>();
            //list.Add(pizza1);
            //list.Add(pizza2);
            //list.Add(bev1);
            //list.Add(bev2);

            //foreach (MenuItem item in list) 
            //{
            //    if (item is Pizza) 
            //    {
            //        Console.WriteLine(((Pizza)item).Number+" "+item.Name+" "+((Pizza)item).Topping+" "+item.Price+"kr");
            //    }
            //
            //    if (item is Beverage) 
            //    {
            //        Console.WriteLine(((Beverage)item).Number+" "+item.Name+" "+((Beverage)item).Size+" "+item.Price+"kr");
            //    }
            //}

           //Order order1 = new Order(list,cus1);
           //
           //foreach (MenuItem item in order1.ItemSummary)
           //{
           //    if (item is Pizza)
           //    {
           //        Console.WriteLine(((Pizza)item).Number + " " + item.Name + " " + ((Pizza)item).Topping + " " + item.Price + "kr");
           //    }
           //
           //    if (item is Beverage)
           //    {
           //        Console.WriteLine(((Beverage)item).Number + " " + item.Name + " " + ((Beverage)item).Size + " " + item.Price + "kr");
           //    }
           //}

            
            //Console.WriteLine("pris: " + order1.TotalPrice + "\nOrdre id: " + order1.Id + "\n" + order1.Date);
            //Console.WriteLine(order1.Customer.Name);
            //Console.WriteLine(" ");
            //
            //Order order2 = new Order(list, cus1);
            //
            //foreach (MenuItem item in order2.ItemSummary)
            //{
            //    if (item is Pizza)
            //    {
            //        Console.WriteLine(((Pizza)item).Number + " " + item.Name + " " + ((Pizza)item).Topping + " " + item.Price + "kr");
            //    }
            //
            //    if (item is Beverage)
            //    {
            //        Console.WriteLine(((Beverage)item).Number + " " + item.Name + " " + ((Beverage)item).Size + " " + item.Price + "kr");
            //    }
            //}
            //
            //Console.WriteLine("pris: " + order2.TotalPrice + "\nOrdre id: " + order2.Id);

            MenuDAL menu1 = new MenuDAL();

            Console.WriteLine("Dagens Menu:");
            foreach (MenuItem item in menu1.MenuItems) 
            {
                if (item is Pizza)
                {
                    Console.WriteLine($"nr.{((Pizza)item).Number} {item.Name} {((Pizza)item).Topping} {item.Price}kr");
                }
                
                if (item is Beverage) 
                {
                    Console.WriteLine($"nr.{((Beverage)item).Number} {((Beverage)item).Type} {item.Name} {((Beverage)item).Size} {item.Price}kr ");
                }
            }

            Menu menu2 = new Menu();
            Console.WriteLine("Dagens Menu:");
            foreach (MenuItem item in menu2.MenuData.MenuItems)
            {
                if (item is Pizza)
                {
                    Console.WriteLine($"nr.{((Pizza)item).Number} {item.Name} {((Pizza)item).Topping} {item.Price}kr");
                }

                if (item is Beverage)
                {
                    Console.WriteLine($"nr.{((Beverage)item).Number} {((Beverage)item).Type} {item.Name} {((Beverage)item).Size} {item.Price}kr ");
                }
            }

        }
    }
}
