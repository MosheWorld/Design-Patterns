using System;

namespace MosheBinieli.State
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMMachine atmMachine = new ATMMachine();

            atmMachine.InsertCard();
            atmMachine.EjectCard();

            atmMachine.InsertCard();

            atmMachine.insertPin(1234);
            atmMachine.RquestCash(2000);
            
            atmMachine.InsertCard();
            atmMachine.insertPin(1234);
        }
    }
}
