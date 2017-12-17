using System;
public class NoCard : IATMState
{
    private ATMMachine atmMachine;

    public NoCard(ATMMachine newATMMachine)
    {
        this.atmMachine = newATMMachine;
    }

    public void EjectCard()
    {
        Console.WriteLine("You didn't enter a card");
    }

    public void InsertCard()
    {
        Console.WriteLine("Please enter your pin");
        atmMachine.atmState = atmMachine.hasCard;
    }

    public void InsertPin(int pinEntered)
    {
        Console.WriteLine("You have not entered your card");
    }

    public void RequestCash(int cashToWithdraw)
    {
        Console.WriteLine("You have not entered your card");
    }
}