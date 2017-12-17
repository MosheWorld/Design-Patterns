public class ThreeCheesePizza : IPizza
{
    private string description = "Mozzarella, Fontina, Parmesan Cheese Pizza";
    private double cost = 10.50;

    public void setDescription(string newDescription)
    {
        description = newDescription;
    }
    
    public double GetCost()
    {
        return cost;
    }

    public string GetDescription()
    {
        return description;
    }
}