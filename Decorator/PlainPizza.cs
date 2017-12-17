public class PlainPizza : IPizza
{
    private string description = "Thin dough";
    private double cost = 4.00;

    public double GetCost()
    {
        return cost;
    }

    public string GetDescription()
    {
        return description;
    }
}