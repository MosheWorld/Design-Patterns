public interface IMediator
{
    void saleOffer(string stock, int shares, int collCode);
    void buyOffer(string stock, int shares, int collCode);
    void addColleague(Colleague newColleague);
}