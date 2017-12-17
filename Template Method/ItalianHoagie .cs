using System;

public class ItalianHoagie : Hoagie
{
    String[] meatUsed = { "Salami", "Pepperoni", "Capicola Ham" };
    String[] cheeseUsed = { "Provolone" };
    String[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
    String[] condimentsUsed = { "Oil", "Vinegar" };

    public override void AddMeat()
    {
        Console.WriteLine("Adding the Meat: ");
        foreach (string meat in meatUsed)
        {
            Console.WriteLine(meat + " ");
        }
    }

    public override void AddCheese()
    {
        Console.WriteLine("Adding the Cheese: ");
        foreach (string cheese in cheeseUsed)
        {
            Console.WriteLine(cheese + " ");
        }
    }

    public override void AddVegetables()
    {
        Console.WriteLine("Adding the Vegetables: ");
        foreach (string veg in veggiesUsed)
        {
            Console.WriteLine(veg + " ");
        }
    }

    public override void AddCondiments()
    {
        Console.WriteLine("Adding the Condiments: ");
        foreach (string con in condimentsUsed)
        {
            Console.WriteLine(con + " ");
        }
    }
}