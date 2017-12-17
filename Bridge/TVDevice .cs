using System;

public class TVDevice : EntertainmentDevice
{
    public TVDevice(int newDeviceState, int newMaxSetting)
    {
        deviceState = newDeviceState;
        maxSetting = newMaxSetting;

    }
    public override void ButtonFivePressed()
    {
        Console.WriteLine("Channel Down");
        deviceState--;

    }

    public override void ButtonSixPressed()
    {
        Console.WriteLine("Channel Up");
        deviceState++;
    }
}