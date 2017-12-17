using System;

namespace MosheBinieli.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.Attach(new ILS());
            subject.Attach(new USD());

            subject.Money = 2;
            subject.Money = 3;
        }
    }
}
