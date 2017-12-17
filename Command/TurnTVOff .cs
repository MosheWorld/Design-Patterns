public class TurnTVOff : ICommand
{
    IElectronicDevice theDevice;

    public TurnTVOff(IElectronicDevice newDevice)
    {
        theDevice = newDevice;
    }

    public void Execute()
    {
        theDevice.Off();
    }

    public void Undo()
    {
        theDevice.On();
    }
}