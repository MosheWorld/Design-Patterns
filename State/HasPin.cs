using System;
public class HasPin : IATMState
{
    private ATMMachine atmMachine;

    public HasPin(ATMMachine newATMMachine)
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
        Console.WriteLine("You already entered a card");
    }

    public void InsertPin(int pinEntered)
    {
        Console.WriteLine("You already entered a PIN");
    }

    public void RequestCash(int cashToWithdraw)
    {
        if (cashToWithdraw > atmMachine.cashInMachine)
        {
            Console.WriteLine("You don't have that much cash available");
            Console.WriteLine("Your card is ejected");
            atmMachine.atmState = atmMachine.noCard;
        }
        else
        {
            Console.WriteLine(cashToWithdraw + " is provided by the machine");
            atmMachine.cashInMachine -= cashToWithdraw;
            Console.WriteLine("Your card is ejected");
            atmMachine.atmState = atmMachine.noCard;

            if (atmMachine.cashInMachine <= 0)
                atmMachine.atmState = atmMachine.atmOutOfMoney;
        }
    }
}