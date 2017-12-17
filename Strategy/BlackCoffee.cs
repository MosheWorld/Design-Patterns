using System.Threading;
using System;

public class BlackCoffee : ICoffee
{
    public void MakeCoffe()
    {
        Console.WriteLine("Making Black Coffee");
        Thread.Sleep(1000);
        Console.WriteLine("Done to make Black Coffee");
    }

    public string GetDetails()
    {
        return "Black Coffee with no sugar.";
    }
}