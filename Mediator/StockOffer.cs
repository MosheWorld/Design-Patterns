public class StockOffer
{
    public int stockShares = 0;
    public string stockSymbol = "";
    public int colleagueCode = 0;

    public StockOffer(int numOfShares, string stock, int collCode)
    {
        this.stockShares = numOfShares;
        this.stockSymbol = stock;
        this.colleagueCode = collCode;
    }

    public int getstockShares()
    {
        return stockShares;
    }

    public string getStockSymbol()
    {
        return stockSymbol;
    }

    public int getCollCode()
    {
        return colleagueCode;
    }

}