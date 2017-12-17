public class SecurityCodeCheck
{
    private int securityCode = 1234;

    public int GetSecurityCode() { return securityCode; }

    public bool IsCodeCorrect(int secCodeToCheck)
    {
        if (secCodeToCheck == GetSecurityCode())
            return true;
        else
            return false;
    }
}