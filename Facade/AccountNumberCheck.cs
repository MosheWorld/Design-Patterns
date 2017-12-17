public class AccountNumberCheck
{
    private int accountNumber = 12345678;
    public int GetAccountNumber() { return accountNumber; }

    public bool AccountActive(int acctNumToCheck)
    {
        if (acctNumToCheck == GetAccountNumber())
            return true;
        else
            return false;
    }
}