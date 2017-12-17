using System;
using System.Collections.Generic;

namespace MosheBinieli.Visitor
{
    class MainApp
    {
        static void Main()
        {
            Employees e = new Employees();
            
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
        }
    }
}


