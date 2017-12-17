using System;
public class NoCash : IATMState
{
    private ATMMachine atmMachine;

    public NoCash(ATMMachine newATMMachine)
    {
        this.atmMachine = newATMMachine;
    }

    public void EjectCard()
    {
        Console.WriteLine("We don't have any money");
        Console.WriteLine("There is no card to eject");
    }

    public void InsertCard()
    {
        Console.WriteLine("We don't have any money");
        Console.WriteLine("There is no card to eject");
    }

    public void InsertPin(int pinEntered)
    {
        Console.WriteLine("We don't have any money");
    }

    public void RequestCash(int cashToWithdraw)
    {
        Console.WriteLine("We don't have any money");
    }
}