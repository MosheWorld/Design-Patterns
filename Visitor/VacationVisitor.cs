using System;

class VacationVisitor : IVisitor
{
    public void Visit(Element element)
    {
        Employee employee = element as Employee;

        employee.VacationDays += 3;
        Console.WriteLine("{0} {1}'s new vacation days: {2}",
          employee.GetType().Name, employee.Name,
          employee.VacationDays);
    }
}