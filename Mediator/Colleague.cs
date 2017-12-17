public abstract class Colleague
{
    private IMediator mediator;
    private int colleagueCode;

    public Colleague(IMediator newMediator)
    {
        mediator = newMediator;
        mediator.addColleague(this);
    }

    public void saleOffer(string stock, int shares)
    {
        mediator.saleOffer(stock, shares, this.colleagueCode);
    }

    public void buyOffer(string stock, int shares)
    {
        mediator.buyOffer(stock, shares, this.colleagueCode);
    }

    public void setCollCode(int collCode)
    {
        this.colleagueCode = collCode;
    }
}