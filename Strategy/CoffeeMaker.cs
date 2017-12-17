public class CoffeeMaker
{
    public ICoffee MyCoffee { get; set; }

    public CoffeeMaker()
    {
        this.MyCoffee = null;
    }

    public CoffeeMaker(ICoffee coffee)
    {
        this.MyCoffee = coffee;
    }

    public void MakeCoffe()
    {
        this.MyCoffee.MakeCoffe();
    }

    public string GetDetails()
    {
        return this.MyCoffee.GetDetails();
    }
}