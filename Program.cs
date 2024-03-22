namespace PizzaStoreV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is my pizza store app

            MenuItem pizza1 = new Pizza(69, "Margherita", "Tomat og ost");
            Pizza pizza2 = new Pizza(76, "Vesuvio", "Tomat, ost og skinke");

            MenuItem bev1 = new Beverage(25, "Coca Cola", "50cl", "sodavand");
            MenuItem bev2 = new Beverage(40, "Coca Cola", "1,5L", "sodavand");

            Console.WriteLine();

            

            List<MenuItem> list = new List<MenuItem>();
            list.Add(pizza1);
            list.Add(pizza2);
            list.Add(bev1);
            list.Add(bev2);

            foreach (MenuItem item in list) 
            {
                if (item is Pizza) 
                {
                    Console.WriteLine(((Pizza)item).Number+" "+item.Name+" "+((Pizza)item).Topping+" "+item.Price+"kr");
                }

                if (item is Beverage) 
                {
                    Console.WriteLine(((Beverage)item).Number+" "+item.Name+" "+((Beverage)item).Size+" "+item.Price+"kr");
                }
            }

        }
    }
}
