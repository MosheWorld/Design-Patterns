public class TurnTVUp : ICommand
{
    IElectronicDevice theDevice;

    public TurnTVUp(IElectronicDevice newDevice)
    {
        theDevice = newDevice;
    }

    public void Execute()
    {
        theDevice.VolumeUp();
    }

    public void Undo()
    {
        theDevice.VolumenDown();
    }
}