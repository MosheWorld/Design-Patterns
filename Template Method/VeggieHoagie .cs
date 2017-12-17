using System;

public class VeggieHoagie : Hoagie
{
    string[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
    string[] condimentsUsed = { "Oil", "Vinegar" };

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

    public override void AddCheese() { }

    public override void AddMeat() { }

}