namespace PizzaStoreV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //MenuController m = new MenuController();
            Menu mm = new Menu();

            foreach (MenuItem p in mm.MenuCon.MenuData.MenuItems)
            {
                if (p is Pizza)
                {
                    Console.WriteLine($"nr.{((Pizza)p).Number} {p.Name} {((Pizza)p).Topping} {p.Price}kr");
                }
                else
                {

                }
            }
            foreach (MenuItem p in mm.MenuCon.MenuData.MenuItems)
            {
                if (p is Beverage)
                {
                    Console.WriteLine($"nr.{((Beverage)p).Number} {((Beverage)p).Type} {p.Name} {((Beverage)p).Size} {p.Price}kr ");
                }
            }
            Console.WriteLine(" ");

            mm.MenuCon.CreatePizza(20, "pepperoni", "Tomat, ost og pepperoni");
            mm.MenuCon.CreateBeverage(89, "IKFK", "50cl", "sodavand");

            foreach (MenuItem p in mm.MenuCon.MenuData.MenuItems)
            {
                if (p is Pizza)
                {
                    Console.WriteLine($"nr.{((Pizza)p).Number} {p.Name} {((Pizza)p).Topping} {p.Price}kr");
                }
                else
                {

                }
            }
            foreach (MenuItem p in mm.MenuCon.MenuData.MenuItems)
            {
                if (p is Beverage)
                {
                    Console.WriteLine($"nr.{((Beverage)p).Number} {((Beverage)p).Type} {p.Name} {((Beverage)p).Size} {p.Price}kr ");
                }
            }
            Console.WriteLine(" ");

            Console.WriteLine(mm.MenuCon.DeleteMenuItem("pepperoni"));
            Console.WriteLine(mm.MenuCon.DeleteMenuItem("pepperoni"));
            Console.WriteLine(mm.MenuCon.DeleteMenuItem("IKFK"));
            Console.WriteLine(mm.MenuCon.UpdateMenuItem("Calzone",90));
            Console.WriteLine(mm.MenuCon.UpdateMenuItem("colzone", 120));

            Console.WriteLine(" ");

            foreach (MenuItem p in mm.MenuCon.MenuData.MenuItems)
            {
                if (p is Pizza)
                {
                    Console.WriteLine($"nr.{((Pizza)p).Number} {p.Name} {((Pizza)p).Topping} {p.Price}kr");
                }
                else
                {

                }
            }
            foreach (MenuItem p in mm.MenuCon.MenuData.MenuItems)
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
