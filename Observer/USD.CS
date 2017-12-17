using System;
public class USD : Observer
{
    private double USDMoney { get; set; }
    public USD()
    {
        this.USDMoney = 2.0;
    }
    public void Update(Subject subject)
    {
        Console.WriteLine($"ILS updated, current {this.USDMoney} and new {this.USDMoney + subject.Money}");
        this.USDMoney += subject.Money;
    }
}