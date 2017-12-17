using System;

public abstract class RemoteButton
{
    private EntertainmentDevice theDevice;
    
    public RemoteButton(EntertainmentDevice newDevice)
    {
        this.theDevice = newDevice;
    }

    public void ButtonFivePressed()
    {
        this.theDevice.ButtonFivePressed();
    }

    public void ButtonSixPressed()
    {
        this.theDevice.ButtonSixPressed();
    }

    public void DeviceFeedback()
    {
        this.theDevice.DeviceFeedback();
    }

    public abstract void ButtonNinePressed();
}