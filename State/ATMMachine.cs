public class ATMMachine
{
    public IATMState hasCard { get; set; }
    public IATMState noCard { get; set; }
    public IATMState hasCorrectPin { get; set; }
    public IATMState atmOutOfMoney { get; set; }
    public IATMState atmState { get; set; }
    public int cashInMachine = 2000;
    public bool correctPinEntered = false;

    public ATMMachine()
    {
        hasCard = new HasCard(this);
        noCard = new NoCard(this);
        hasCorrectPin = new HasPin(this);
        atmOutOfMoney = new NoCash(this);
        atmState = noCard;

        if (cashInMachine < 0)
        {
            atmState = atmOutOfMoney;
        }
    }

    public void InsertCard()
    {
        this.atmState.InsertCard();
    }

    public void EjectCard()
    {
        this.atmState.EjectCard();
    }

    public void RquestCash(int cashToWithdraw)
    {
        atmState.RequestCash(cashToWithdraw);
    }

    public void insertPin(int pinEntered)
    {
        atmState.InsertPin(pinEntered);

    }
}