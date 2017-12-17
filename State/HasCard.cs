using System;
public class HasCard : IATMState
{
    private ATMMachine atmMachine;

    public HasCard(ATMMachine newATMMachine)
    {
        this.atmMachine = newATMMachine;
    }
    public void EjectCard()
    {
        Console.WriteLine("Your card is ejected");
        atmMachine.atmState = atmMachine.noCard;
    }

    public void InsertCard()
    {
        Console.WriteLine("You can only insert one card at a time");
    }

    public void InsertPin(int pinEntered)
    {
        if (pinEntered == 1234)
        {
            Console.WriteLine("You entered the correct PIN");
            atmMachine.correctPinEntered = true;
            atmMachine.atmState = atmMachine.hasCorrectPin;
        }
        else
        {
            Console.WriteLine("You entered the wrong PIN");
            atmMachine.correctPinEntered = false;
            Console.WriteLine("Your card is ejected");
            atmMachine.atmState = atmMachine.noCard;
        }
    }

    public void RequestCash(int cashToWithdraw)
    {
        Console.WriteLine("You have not entered your PIN");
    }
}