using System;

public class DivideNumbers : IChain
{
    private IChain nextInChain;

    public void calculate(Numbers request)
    {
        if (request.calculationWanted == Operations.Division)
        {
            Console.WriteLine(request.number1 + " / " + request.number2 + " = " + (request.number1 / request.number2));
        }
        else
        {
            Console.WriteLine("Only works for add, sub, mult, and div");
        }
    }

    public void setNextChain(IChain nextChain)
    {
        nextInChain = nextChain;
    }
}