using System;
using System.Collections.Generic;
using System.Linq;
public class ProspectMemory
{
    private List<Memento> _mementoList;

    public ProspectMemory()
    {
        this._mementoList = new List<Memento>();
    }

    public void Insert(Memento newMomento)
    {
        this._mementoList.Add(newMomento);
    }

    public Memento Get()
    {
        if (this._mementoList.Count > 0)
        {
            Memento toReturn = this._mementoList.LastOrDefault();
            this._mementoList.RemoveAt(this._mementoList.Count - 1);
            return toReturn;
        }
        else
        {
            Console.WriteLine("Notthing in memory.");
            return null;
        }
    }
}