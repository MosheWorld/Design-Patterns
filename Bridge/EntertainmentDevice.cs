using System;

public abstract class EntertainmentDevice
{
    public int deviceState;
    public int maxSetting;
    public int volumeLevel = 0;
    public abstract void ButtonFivePressed();
    public abstract void ButtonSixPressed();
    
    public void DeviceFeedback()
    {
        if (deviceState > maxSetting || deviceState < 0)
            deviceState = 0;
        Console.WriteLine("On Channel " + deviceState);
    }

    public void ButtonSevenPressed()
    {
        this.volumeLevel++;
        Console.WriteLine("Volume at: " + volumeLevel);
    }

    public void ButtonEightPressed()
    {
        this.volumeLevel--;
        Console.WriteLine("Volume at: " + volumeLevel);
    }
}