using System;

namespace MosheBinieli.Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ItalianHoagie cust12Hoagie = new ItalianHoagie();
            cust12Hoagie.MakeSandwich();

            Console.WriteLine("-----------------------");

            VeggieHoagie cust13Hoagie = new VeggieHoagie();
            cust13Hoagie.MakeSandwich();
        }
    }
}
