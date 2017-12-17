using System;
public class Mozzarella : ToppingDecorator
{
    public Mozzarella(IPizza newPizza) : base(newPizza)
    {
        Console.WriteLine("Adding Mozzarella");
    }

    public override string GetDescription()
    {
        return tempPizza.GetDescription() + ", Mozzarella";
    }

    public override double GetCost()
    {
        return tempPizza.GetCost() + 0.50;
    }
}