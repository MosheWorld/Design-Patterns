using System;

public class TurnTVDown : ICommand
{
    IElectronicDevice theDevice;

    public TurnTVDown(IElectronicDevice newDevice)
    {
        theDevice = newDevice;
    }

    public void Execute()
    {
        theDevice.VolumenDown();
    }

    public void Undo()
    {
        theDevice.VolumeUp();
    }
}