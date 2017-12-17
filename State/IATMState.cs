public interface IATMState
{
    void InsertCard();
    void EjectCard();
    void InsertPin(int pinEntered);
    void RequestCash(int cashToWithdraw);

}