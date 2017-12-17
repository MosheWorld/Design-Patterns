using System;

namespace MosheBinieli.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker coffee = new CoffeeMaker(new BlackCoffee());
            DoAction(coffee);

            coffee.MyCoffee = new NessCoffee();
            DoAction(coffee);
        }

        public static void DoAction(CoffeeMaker coffee)
        {
            coffee.MakeCoffe();
            Console.WriteLine("Details about the coffee: " + coffee.GetDetails());
        }
    }
}
