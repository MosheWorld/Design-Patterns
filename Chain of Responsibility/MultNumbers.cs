using System;

public class MultNumbers : IChain
{
    private IChain nextInChain;

    public void calculate(Numbers request)
    {
        if (request.calculationWanted == Operations.Multiplication)
        {
            Console.WriteLine(request.number1 + " * " + request.number2 + " = " + (request.number1 * request.number2));
        }
        else
        {
            nextInChain.calculate(request);
        }
    }

    public void setNextChain(IChain nextChain)
    {
        nextInChain = nextChain;
    }
}

