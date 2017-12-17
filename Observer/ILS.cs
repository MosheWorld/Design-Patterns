using System;

public class ILS : Observer
{
    private double ILSMoney { get; set; }
    public ILS()
    {
        this.ILSMoney = 6.0;
    }
    public void Update(Subject subject)
    {
        Console.WriteLine($"ILS updated, current {this.ILSMoney} and new {this.ILSMoney + subject.Money}");
        this.ILSMoney += subject.Money;
    }
}