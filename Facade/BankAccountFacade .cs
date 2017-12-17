using System;

public class BankAccountFacade
{
    private int accountNumber { get; set; }
    private int securityCode { get; set; }

    AccountNumberCheck acctChecker;
    SecurityCodeCheck codeChecker;
    FundsCheck fundChecker;
    WelcomeToBank bankWelcome;

    public BankAccountFacade(int newAcctNum, int newSecCode)
    {
        accountNumber = newAcctNum;
        securityCode = newSecCode;

        bankWelcome = new WelcomeToBank();
        acctChecker = new AccountNumberCheck();
        fundChecker = new FundsCheck();
        codeChecker = new SecurityCodeCheck();
    }

    public void WithdrawCash(double cashToGet)
    {
        if (acctChecker.AccountActive(accountNumber) &&
        codeChecker.IsCodeCorrect(securityCode) &&
        fundChecker.HaveEnoughMoney(cashToGet))
        {
            Console.WriteLine("Transaction Complete\n");
        }
        else
        {
            Console.WriteLine("Transaction Failed\n");
        }
    }

    public void DepositCash(double cashToDeposit)
    {
        if (acctChecker.AccountActive(accountNumber) && codeChecker.IsCodeCorrect(securityCode))
        {
            fundChecker.makeDeposit(cashToDeposit);
            Console.WriteLine("Transaction Complete\n");
        }
        else
        {
            Console.WriteLine("Transaction Failed\n");
        }
    }
}