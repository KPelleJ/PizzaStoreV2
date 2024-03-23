namespace PizzaStoreV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            MenuController m = new MenuController();

            foreach (MenuItem p in m.MenuData.MenuItems)
            {
                if (p is Pizza)
                {
                    Console.WriteLine($"nr.{((Pizza)p).Number} {p.Name} {((Pizza)p).Topping} {p.Price}kr");
                }
                else
                {

                }
            }
            foreach (MenuItem p in m.MenuData.MenuItems)
            {
                if (p is Beverage)
                {
                    Console.WriteLine($"nr.{((Beverage)p).Number} {((Beverage)p).Type} {p.Name} {((Beverage)p).Size} {p.Price}kr ");
                }
            }
            Console.WriteLine(" ");

            m.CreatePizza(20, "pepperoni", "Tomat, ost og pepperoni");
            m.CreateBeverage(89, "IKFK", "50cl", "sodavand");

            foreach (MenuItem p in m.MenuData.MenuItems)
            {
                if (p is Pizza)
                {
                    Console.WriteLine($"nr.{((Pizza)p).Number} {p.Name} {((Pizza)p).Topping} {p.Price}kr");
                }
                else
                {

                }
            }
            foreach (MenuItem p in m.MenuData.MenuItems)
            {
                if (p is Beverage)
                {
                    Console.WriteLine($"nr.{((Beverage)p).Number} {((Beverage)p).Type} {p.Name} {((Beverage)p).Size} {p.Price}kr ");
                }
            }
            Console.WriteLine(" ");

            Console.WriteLine(m.DeleteMenuItem("pepperoni"));
            Console.WriteLine(m.DeleteMenuItem("pepperoni"));
            Console.WriteLine(m.DeleteMenuItem("IKFK"));
            Console.WriteLine(m.UpdateMenuItem("Calzone",90));
            Console.WriteLine(m.UpdateMenuItem("colzone", 120));

            Console.WriteLine(" ");

            foreach (MenuItem p in m.MenuData.MenuItems)
            {
                if (p is Pizza)
                {
                    Console.WriteLine($"nr.{((Pizza)p).Number} {p.Name} {((Pizza)p).Topping} {p.Price}kr");
                }
                else
                {

                }
            }
            foreach (MenuItem p in m.MenuData.MenuItems)
            {
                if (p is Beverage)
                {
                    Console.WriteLine($"nr.{((Beverage)p).Number} {((Beverage)p).Type} {p.Name} {((Beverage)p).Size} {p.Price}kr ");
                }
            }
            Console.WriteLine(" ");

        }
    }
}
