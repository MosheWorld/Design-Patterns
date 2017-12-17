using System;

namespace MosheBinieli.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine("Ingredients: " + basicPizza.GetDescription());

            Console.WriteLine("Price: " + basicPizza.GetCost());
        }
    }
}
