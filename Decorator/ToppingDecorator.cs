public abstract class ToppingDecorator : IPizza
{
    protected IPizza tempPizza;

    public ToppingDecorator(IPizza newPizza)
    {
        this.tempPizza = newPizza;
    }

    public virtual double GetCost()
    {
        return tempPizza.GetCost();
    }
    public virtual string GetDescription()
    {
        return tempPizza.GetDescription();
    }
}