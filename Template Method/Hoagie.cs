using System;

public abstract class Hoagie
{
    public void MakeSandwich()
    {
        cutBun();

        if (customerWantsMeat())
        {
            AddMeat();
            NewLine();
        }

        if (customerWantsCheese())
        {
            AddCheese();
            NewLine();
        }

        if (customerWantsVegetables())
        {
            AddVegetables();
            NewLine();
        }

        if (customerWantsCondiments())
        {
            AddCondiments();
            NewLine();
        }

        wrapTheHoagie();
    }

    public abstract void AddMeat();
    public abstract void AddCheese();
    public abstract void AddVegetables();
    public abstract void AddCondiments();

    bool customerWantsMeat() { return true; }
    bool customerWantsCheese() { return true; }
    bool customerWantsVegetables() { return true; }
    bool customerWantsCondiments() { return true; }

    public void cutBun()
    {
        Console.WriteLine("The Hoagie is Cut");
    }

    public void wrapTheHoagie()
    {
        Console.WriteLine("\nWrap the Hoagie");
    }

    public void NewLine()
    {
        Console.WriteLine();
    }
}