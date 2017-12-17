using System;
public class TomatoSauce : ToppingDecorator
{
    public TomatoSauce(IPizza newPizza) : base(newPizza)
    {
        Console.WriteLine("Adding Tomato Sauce");
    }

    public override string GetDescription()
    {
        return tempPizza.GetDescription() + ", Tomato Sauce";
    }

    public override double GetCost()
    {
        return tempPizza.GetCost() + 0.35;
    }
}