using System;
using System.Collections.Generic;
public class Subject
{
    private List<Observer> ObserverList;
    private int money;

    public Subject()
    {
        this.ObserverList = new List<Observer>();
        this.money = 5;
    }

    public int Money
    {
        get { return money; }
        set { money = value; this.Notify(); }
    }

    public void Attach(Observer observer)
    {
        this.ObserverList.Add(observer);
    }

    public void Notify()
    {
        foreach (Observer item in ObserverList)
        {
            item.Update(this);
        }
    }
}