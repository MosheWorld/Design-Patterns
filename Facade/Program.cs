using System;

namespace MosheBinieli.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountFacade accessingBank = new BankAccountFacade(12345678, 1234);
            
            accessingBank.WithdrawCash(50.00);
            accessingBank.WithdrawCash(990.00);
        }
    }
}
