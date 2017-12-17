using System;
using System.Collections.Generic;

public class TurnItAllOff : ICommand
{
    List<IElectronicDevice> theDevices;

    public TurnItAllOff(List<IElectronicDevice> newDevices)
    {
        theDevices = newDevices;
    }


    public void Execute()
    {
        foreach (IElectronicDevice item in theDevices)
            item.Off();
    }

    public void Undo()
    {
        foreach (IElectronicDevice item in theDevices)
            item.On();
    }
}