public class Numbers
{
    public int number1 { get; set; }
    public int number2 { get; set; }
    public Operations calculationWanted { get; set; }

    public Numbers(int newNumber1, int newNumber2, Operations calcWanted)
    {
        this.number1 = newNumber1;
        this.number2 = newNumber2;
        this.calculationWanted = calcWanted;
    }
}