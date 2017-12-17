using System;

namespace MosheBinieli.Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IChain chainCalc1 = new AddNumbers();
            IChain chainCalc2 = new SubtractNumbers();
            IChain chainCalc3 = new MultNumbers();
            IChain chainCalc4 = new DivideNumbers();

            chainCalc1.setNextChain(chainCalc2);
            chainCalc2.setNextChain(chainCalc3);
            chainCalc3.setNextChain(chainCalc4);

            Numbers request = new Numbers(4, 2, Operations.Multiplication);
            
            chainCalc1.calculate(request);
        }
    }
}
