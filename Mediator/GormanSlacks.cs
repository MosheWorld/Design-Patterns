using System;

public class GormanSlacks : Colleague
{
    public GormanSlacks(IMediator newMediator) : base(newMediator)
    {
        Console.WriteLine("Gorman Slacks signed up with the stockexchange\n");
    }
}