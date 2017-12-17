using System;

public class JTPoorman : Colleague
{
    public JTPoorman(IMediator newMediator) : base(newMediator)
    {
        Console.WriteLine("JT Poorman signed up with the stockexchange\n");
    }
}