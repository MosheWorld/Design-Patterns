using System;
using System.Collections.Generic;

public class StockMediator : IMediator
{
    private List<Colleague> colleagues;
    private List<StockOffer> stockBuyOffers;
    private List<StockOffer> stockSaleOffers;
    private int colleagueCodes = 0;

    public StockMediator()
    {
        this.colleagues = new List<Colleague>();
        this.stockBuyOffers = new List<StockOffer>();
        this.stockSaleOffers = new List<StockOffer>();
    }
    public void addColleague(Colleague newColleague)
    {
        colleagues.Add(newColleague);
        colleagueCodes++;
        newColleague.setCollCode(colleagueCodes);
    }

    public void buyOffer(string stock, int shares, int collCode)
    {
        bool stockBought = false;

        foreach (StockOffer offer in stockSaleOffers)
        {
            if ((offer.getStockSymbol() == stock) && (offer.getstockShares() == shares))
            {
                Console.WriteLine(shares + " shares of " + stock + " bought by colleague code " + offer.getCollCode());
                stockSaleOffers.Remove(offer);
                stockBought = true;
            }

            if (stockBought)
                break;
        }

        if (!stockBought)
        {
            Console.WriteLine(shares + " shares of " + stock + " added to inventory");
            StockOffer newOffering = new StockOffer(shares, stock, collCode);
            stockBuyOffers.Add(newOffering);
        }
    }

    public void saleOffer(string stock, int shares, int collCode)
    {
        bool stockSold = false;

        foreach (StockOffer offer in stockBuyOffers)
        {
            if ((offer.getStockSymbol() == stock) && (offer.getstockShares() == shares))
            {
                Console.WriteLine(shares + " shares of " + stock + " sold to colleague code " + offer.getCollCode());
                stockBuyOffers.Remove(offer);
                stockSold = true;
            }

            if (stockSold)
                break;

        }

        if (!stockSold)
        {
            Console.WriteLine(shares + " shares of " + stock + " added to inventory");
            StockOffer newOffering = new StockOffer(shares, stock, collCode);
            stockSaleOffers.Add(newOffering);
        }
    }

    public void getstockOfferings()
    {
        Console.WriteLine("\nStocks for Sale");

        foreach (StockOffer offer in stockSaleOffers)
        {
            Console.WriteLine(offer.getstockShares() + " of " + offer.getStockSymbol());
        }

        Console.WriteLine("\nStock Buy Offers");

        foreach (StockOffer offer in stockBuyOffers)
        {
            Console.WriteLine(offer.getstockShares() + " of " + offer.getStockSymbol());
        }
    }
}