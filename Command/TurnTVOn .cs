using System;

public class TurnTVOn : ICommand
{
    IElectronicDevice theDevice;

    public TurnTVOn(IElectronicDevice newDevice)
    {
        theDevice = newDevice;
    }

    public void Execute()
    {
        theDevice.On();
    }

    public void Undo()
    {
        theDevice.Off();
    }
}