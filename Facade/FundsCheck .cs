using System;

public class FundsCheck
{
    private double cashInAccount = 1000.00;

    public double GetCashInAccount() { return cashInAccount; }

    public void DecreaseCashInAccount(double cashWithdrawn)
    {
        cashInAccount -= cashWithdrawn;
    }
    public void IncreaseCashInAccount(double cashDeposited)
    {
        cashInAccount += cashDeposited;
    }

    public bool HaveEnoughMoney(double cashToWithdrawal)
    {
        if (cashToWithdrawal > GetCashInAccount())
        {
            Console.WriteLine("Error: You don't have enough money");
            Console.WriteLine("Current Balance: " + GetCashInAccount());
            return false;
        }
        else
        {
            DecreaseCashInAccount(cashToWithdrawal);
            Console.WriteLine("Withdrawal Complete: Current Balance is " + GetCashInAccount());
            return true;
        }
    }

    public void makeDeposit(double cashToDeposit)
    {
        IncreaseCashInAccount(cashToDeposit);
        Console.WriteLine("Deposit Complete: Current Balance is " + GetCashInAccount());
    }
}